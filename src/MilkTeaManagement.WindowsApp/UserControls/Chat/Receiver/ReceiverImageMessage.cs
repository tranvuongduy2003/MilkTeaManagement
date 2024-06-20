namespace MilkTeaManagement.WindowsApp.UserControls.Chat.Receiver
{
    public partial class ReceiverImageMessage : UserControl
    {
        public ReceiverImageMessage()
        {
            InitializeComponent();
        }

        public void OnLoad(string imageUrl)
        {
            Avatar.Hide();
            Image.ImageLocation = imageUrl;
        }

        public void OnLoad(string imageUrl, string avatar)
        {
            Avatar.ImageLocation = avatar;
            Image.ImageLocation = imageUrl;
        }
    }
}
