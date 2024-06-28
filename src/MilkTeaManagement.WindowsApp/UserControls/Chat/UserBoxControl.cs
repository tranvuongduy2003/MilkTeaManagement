using MilkTeaManagement.Application.Common.Models.Chat;

namespace MilkTeaManagement.WindowsApp.UserControls.Chat
{
    public partial class UserBoxControl : UserControl
    {
        public ConversationDto Conversation { get; set; }

        public UserBoxControl()
        {
            InitializeComponent();
            this.avatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void OnLoad(ConversationDto conversation)
        {
            Conversation = conversation;
            this.fullName.Text = conversation.Name;
            this.avatar.ImageLocation = conversation.Avatar;
            this.message.Text = conversation.LastMessage ?? "";
        }
    }
}
