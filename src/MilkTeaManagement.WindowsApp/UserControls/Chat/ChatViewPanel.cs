using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Common.Models.Chat;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.WindowsApp.UserControls.Chat
{
    public partial class ChatViewPanel : UserControl
    {
        private readonly UserManager<User> _userManager;
        private readonly IMessagesRepository _messagesRepository;
        private readonly IMapper _mapper;

        public ConversationDto Conversation { get; set; }

        public List<MessageDto> Messages { get; set; } = new List<MessageDto>();

        public ChatViewPanel(UserManager<User> userManager, IMessagesRepository messagesRepository, IMapper mapper)
        {
            InitializeComponent();
            _userManager = userManager;
            _messagesRepository = messagesRepository;
            _mapper = mapper;
        }

        public async void OnLoad(ConversationDto conversation)
        {
            Conversation = conversation;
            Avatar.ImageLocation = conversation.Avatar;
            FullName.Text = conversation.Name;
            var receiver = await _userManager.FindByIdAsync(conversation.ReceiverId);
            var roles = await _userManager.GetRolesAsync(receiver);
            Role.Text = roles.FirstOrDefault();

            var messages = await _messagesRepository
                .FindByCondition(x => x.ConversationId.Equals(conversation.Id))
                .OrderBy(x => x.CreatedDate)
                .ToListAsync();
            Messages = _mapper.Map<List<MessageDto>>(messages);

            MessagesPanel.Controls.Clear();
            if (Messages[0].SenderId == Program.UserIdentity.Id)
            {
                var messageControl = new SelfMessage();
                messageControl.OnLoad(Messages[0].Content);
                MessagesPanel.Controls.Add(messageControl);
            }
            else
            {
                var messageControl = new ReceiverMessage();
                messageControl.OnLoad(Messages[0].Content, Conversation.Avatar);
                MessagesPanel.Controls.Add(messageControl);
            }

            for (int i = 1; i < Messages.Count; i++)
            {
                AddMessage(i);
            }
        }

        private void ChatViewPanel_Load(object sender, EventArgs e)
        {
            Program.SignalRConnection.On<MessageDto>("ReceiveMessage", (message) =>
            {
                this.Invoke(new Action(() =>
                {
                    Messages.Add(message);
                    AddMessage(Messages.Count - 1);
                }));
            });
        }

        private async void Send_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new SendMessageRequest
                {
                    ConversationId = Conversation.Id,
                    SenderId = Program.UserIdentity.Id,
                    ReceiverId = Conversation.ReceiverId,
                    Content = Content.Text,
                };
                Content.Text = "";
                await Program.SignalRConnection.InvokeAsync("SendMessage", request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddMessage(int index)
        {
            Control messageControl = new Control();
            if (Messages[index - 1].SenderId != Messages[index].SenderId)
            {
                if (Messages[index].SenderId == Program.UserIdentity.Id)
                {
                    messageControl = new SelfMessage();
                    messageControl.Margin = new Padding(0, 10, 0, 0);
                    (messageControl as SelfMessage).OnLoad(Messages[index].Content);
                }
                else
                {
                    messageControl = new ReceiverMessage();
                    messageControl.Margin = new Padding(0, 10, 0, 0);
                    (messageControl as ReceiverMessage).OnLoad(Messages[index].Content, Conversation.Avatar);
                }
            }
            else
            {
                if (Messages[index].SenderId == Program.UserIdentity.Id)
                {
                    messageControl = new SelfMessage();
                    (messageControl as SelfMessage).OnLoad(Messages[index].Content);
                }
                else
                {
                    messageControl = new ReceiverMessage();
                    (messageControl as ReceiverMessage).OnLoad(Messages[index].Content);
                }
            }
            MessagesPanel.Controls.Add(messageControl);
            MessagesPanel.ScrollControlIntoView(messageControl);
        }
    }
}
