using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Common.Models.Chat;
using MilkTeaManagement.Application.Common.Models.Files;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.UserControls.Chat.Receiver;
using MilkTeaManagement.WindowsApp.UserControls.Chat.Self;

namespace MilkTeaManagement.WindowsApp.UserControls.Chat
{
    public partial class ChatViewPanel : UserControl
    {
        private readonly IAzureBlobService _blobService;
        private readonly UserManager<User> _userManager;
        private readonly IMessagesRepository _messagesRepository;
        private readonly IMapper _mapper;

        public ConversationDto Conversation { get; set; }

        public List<MessageDto> Messages { get; set; } = new List<MessageDto>();

        public ChatViewPanel(IAzureBlobService blobService, UserManager<User> userManager, IMessagesRepository messagesRepository, IMapper mapper)
        {
            InitializeComponent();
            _blobService = blobService;
            _userManager = userManager;
            _messagesRepository = messagesRepository;
            _mapper = mapper;

            Avatar.SizeMode = PictureBoxSizeMode.Zoom;
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
            RenderFirstMessage();
            for (int i = 1; i < Messages.Count; i++)
                RenderMessage(Messages[i], i);
        }

        private void ChatViewPanel_Load(object sender, EventArgs e)
        {
            Program.SignalRConnection.On("ReceiveMessage", (Action<MessageDto>)((message) =>
            {
                this.Invoke(new Action(() =>
                {
                    Messages.Add(message);
                    RenderMessage(message, Messages.Count - 1);
                }));
            }));
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

        private async void SendVideo_Click(object sender, EventArgs e)
        {
            BlobResponseDto uploadedVideo = new();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mov;*.wmv;*.mp4;*.webm;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedVideo = await _blobService.UploadAsync(openFileDialog.FileName);
            }
            try
            {
                var request = new SendMessageRequest
                {
                    ConversationId = Conversation.Id,
                    SenderId = Program.UserIdentity.Id,
                    ReceiverId = Conversation.ReceiverId,
                    Video = uploadedVideo.Blob.Uri,
                };
                await Program.SignalRConnection.InvokeAsync("SendMessage", request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void SendImage_Click(object sender, EventArgs e)
        {
            BlobResponseDto uploadedImage = new();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedImage = await _blobService.UploadAsync(openFileDialog.FileName);
            }
            try
            {
                var request = new SendMessageRequest
                {
                    ConversationId = Conversation.Id,
                    SenderId = Program.UserIdentity.Id,
                    ReceiverId = Conversation.ReceiverId,
                    Image = uploadedImage.Blob.Uri,
                };
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

        private void AddImageMessage(int index)
        {
            Control messageControl = new Control();
            if (Messages[index - 1].SenderId != Messages[index].SenderId)
            {
                if (Messages[index].SenderId == Program.UserIdentity.Id)
                {
                    messageControl = new SelfImageMessage();
                    messageControl.Margin = new Padding(0, 10, 0, 0);
                    (messageControl as SelfImageMessage).OnLoad(Messages[index].Image);
                }
                else
                {
                    messageControl = new ReceiverImageMessage();
                    messageControl.Margin = new Padding(0, 10, 0, 0);
                    (messageControl as ReceiverImageMessage).OnLoad(Messages[index].Image, Conversation.Avatar);
                }
            }
            else
            {
                if (Messages[index].SenderId == Program.UserIdentity.Id)
                {
                    messageControl = new SelfImageMessage();
                    (messageControl as SelfImageMessage).OnLoad(Messages[index].Image);
                }
                else
                {
                    messageControl = new ReceiverImageMessage();
                    (messageControl as ReceiverImageMessage).OnLoad(Messages[index].Image);
                }
            }
            MessagesPanel.Controls.Add(messageControl);
            MessagesPanel.ScrollControlIntoView(messageControl);
        }

        private void AddVideoMessage(int index)
        {
            Control messageControl = new Control();
            if (Messages[index - 1].SenderId != Messages[index].SenderId)
            {
                if (Messages[index].SenderId == Program.UserIdentity.Id)
                {
                    messageControl = new SelfVideoMessage();
                    messageControl.Margin = new Padding(0, 10, 0, 0);
                    (messageControl as SelfVideoMessage).OnLoad(Messages[index].Video);
                }
                else
                {
                    messageControl = new ReceiverVideoMessage();
                    messageControl.Margin = new Padding(0, 10, 0, 0);
                    (messageControl as ReceiverVideoMessage).OnLoad(Messages[index].Video, Conversation.Avatar);
                }
            }
            else
            {
                if (Messages[index].SenderId == Program.UserIdentity.Id)
                {
                    messageControl = new SelfVideoMessage();
                    (messageControl as SelfVideoMessage).OnLoad(Messages[index].Video);
                }
                else
                {
                    messageControl = new ReceiverVideoMessage();
                    (messageControl as ReceiverVideoMessage).OnLoad(Messages[index].Video);
                }
            }
            MessagesPanel.Controls.Add(messageControl);
            MessagesPanel.ScrollControlIntoView(messageControl);
        }

        private void AddFirstMessage()
        {
            Control messageControl = new Control();
            if (Messages[0].SenderId == Program.UserIdentity.Id)
            {
                messageControl = new SelfMessage();
                (messageControl as SelfMessage).OnLoad(Messages[0].Content);
            }
            else
            {
                messageControl = new ReceiverMessage();
                (messageControl as ReceiverMessage).OnLoad(Messages[0].Content, Conversation.Avatar);
            }
            MessagesPanel.Controls.Add(messageControl);
            MessagesPanel.ScrollControlIntoView(messageControl);
        }

        private void AddFirstImageMessage()
        {
            Control messageControl = new Control();
            if (Messages[0].SenderId == Program.UserIdentity.Id)
            {
                messageControl = new SelfImageMessage();
                (messageControl as SelfImageMessage).OnLoad(Messages[0].Image);
            }
            else
            {
                messageControl = new ReceiverImageMessage();
                (messageControl as ReceiverImageMessage).OnLoad(Messages[0].Image, Conversation.Avatar);
            }
            MessagesPanel.Controls.Add(messageControl);
            MessagesPanel.ScrollControlIntoView(messageControl);
        }

        private void AddFirstVideoMessage()
        {
            Control messageControl = new Control();
            if (Messages[0].SenderId == Program.UserIdentity.Id)
            {
                messageControl = new SelfVideoMessage();
                (messageControl as SelfVideoMessage).OnLoad(Messages[0].Video);
            }
            else
            {
                messageControl = new ReceiverVideoMessage();
                (messageControl as ReceiverVideoMessage).OnLoad(Messages[0].Video, Conversation.Avatar);
            }
            MessagesPanel.Controls.Add(messageControl);
            MessagesPanel.ScrollControlIntoView(messageControl);
        }

        private void RenderMessage(MessageDto message, int index)
        {
            if (!message.Content.IsNullOrEmpty())
                AddMessage(index);
            else if (!message.Image.IsNullOrEmpty())
                AddImageMessage(index);
            else if (!message.Video.IsNullOrEmpty())
                AddVideoMessage(index);
        }

        private void RenderFirstMessage()
        {
            if (!Messages[0].Content.IsNullOrEmpty())
                AddFirstMessage();
            else if (!Messages[0].Image.IsNullOrEmpty())
                AddFirstImageMessage();
            else if (!Messages[0].Video.IsNullOrEmpty())
                AddFirstVideoMessage();
        }
    }
}
