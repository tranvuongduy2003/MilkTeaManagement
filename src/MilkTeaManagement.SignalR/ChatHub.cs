using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Common.Models.Chat;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Data;
using ILogger = Serilog.ILogger;

namespace MilkTeaManagement.SignalR
{
    public class ChatHub : Hub
    {
        private readonly static List<string> _connections = new List<string>();

        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IAzureBlobService _blobService;
        private readonly IConversationsRepository _conversationsRepository;
        private readonly IMessagesRepository _messagesRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ChatHub(ILogger logger, ApplicationDbContext context, UserManager<User> userManager, IAzureBlobService blobService, IConversationsRepository conversationsRepository, IMessagesRepository messagesRepository, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _blobService = blobService;
            _conversationsRepository = conversationsRepository;
            _messagesRepository = messagesRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task TestConnection()
        {
            _logger.Information("Invoke Test Connection");
            await Clients.All.SendAsync("TestConnection", "Connect successfully!");
        }

        public async Task JoinChatRoom(JoinChatRoomRequest request)
        {
            _logger.Information($"BEGIN: JoinChatRoom");
            var sender = await _userManager.FindByIdAsync(request.SenderId);
            if (sender == null)
                throw new Exception($"User with id {request.SenderId} does not exist");

            var receiver = await _userManager.FindByIdAsync(request.ReceiverId);
            if (receiver == null)
                throw new Exception($"User with id {request.ReceiverId} does not exist");

            var conversation = await _conversationsRepository.GetByIdAsync(request.ConversationId);

            _logger.Information($"JoinChatRoom: Joined Context Connection id: {Context.ConnectionId}");
            await Groups.AddToGroupAsync(Context.ConnectionId, conversation.Id);
            await Clients.Group(conversation.Id).SendAsync("JoinChatRoom", conversation, $"{sender.FullName} has joined conversation {conversation.Id}");
            _logger.Information($"END: JoinChatRoom");
        }

        public async Task SendMessage(SendMessageRequest request)
        {
            _logger.Information($"BEGIN: SendMessage");
            var conversation = await _conversationsRepository.GetByIdAsync(request.ConversationId);
            if (conversation == null)
                throw new Exception($"Conversation with id {request.ConversationId} does not exist");

            var sender = await _userManager.FindByIdAsync(request.SenderId);
            if (sender == null)
                throw new Exception($"User with id {request.SenderId} does not exist");

            var receiver = await _userManager.FindByIdAsync(request.ReceiverId);
            if (receiver == null)
                throw new Exception($"User with id {request.ReceiverId} does not exist");

            var message = new Message
            {
                ConversationId = request.ConversationId,
                Content = request.Content,
                SenderId = request.SenderId,
                ReceiverId = request.ReceiverId,
                Icon = request.Icon,
                Image = request.Image,
                Video = request.Video,
                CreatedDate = DateTime.UtcNow,
            };

            await _messagesRepository.CreateAsync(message);
            await _messagesRepository.SaveChangesAsync();

            _logger.Information($"SendMessage: Context Connection id: {Context.ConnectionId}");
            await Groups.AddToGroupAsync(Context.ConnectionId, conversation.Id);
            var messageDto = _mapper.Map<MessageDto>(message);
            await Clients.Group(conversation.Id).SendAsync("ReceiveMessage", messageDto);
            _logger.Information($"END: SendMessage");
        }
    }
}
