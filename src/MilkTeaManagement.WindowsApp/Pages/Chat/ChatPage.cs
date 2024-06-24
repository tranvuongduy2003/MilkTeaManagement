using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Common.Models.Chat;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.WindowsApp.Helpers;
using MilkTeaManagement.WindowsApp.UserControls.Chat;

namespace MilkTeaManagement.WindowsApp.Pages.Chat
{
    public partial class ChatPage : Page
    {
        private readonly IConversationsRepository _conversationsRepository;

        public ChatPage(IConversationsRepository conversationsRepository)
        {
            InitializeComponent();
            _conversationsRepository = conversationsRepository;
        }

        public override async void OnLoad()
        {
            var conversations = await _conversationsRepository.GetConversationsBySenderId(Program.UserIdentity.Id);

            ConversationsPanel.Controls.Clear();
            foreach (var conversation in conversations)
            {
                UserBoxControl userBoxControl = new UserBoxControl();
                userBoxControl.OnLoad(conversation);
                userBoxControl.Click += new EventHandler((object sender, EventArgs e) => OnClickUserBox(conversation));
                ConversationsPanel.Controls.Add(userBoxControl);
            }
        }

        private async void OnClickUserBox(ConversationDto conversation)
        {
            ChatViewPanel chatViewPanel = Program.ServiceProvider.GetRequiredService<ChatViewPanel>();
            chatViewPanel.OnLoad(conversation);
            ChatView.Controls.Clear();
            ChatView.Controls.Add(chatViewPanel);

            var request = new JoinChatRoomRequest
            {
                ConversationId = conversation.Id,
                ReceiverId = conversation.ReceiverId,
                SenderId = conversation.SenderId
            };
            try
            {
                await Program.SignalRConnection.InvokeAsync("JoinChatRoom", request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
