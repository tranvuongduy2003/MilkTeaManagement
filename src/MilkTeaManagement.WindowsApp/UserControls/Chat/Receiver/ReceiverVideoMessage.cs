namespace MilkTeaManagement.WindowsApp.UserControls.Chat.Receiver
{
    public partial class ReceiverVideoMessage : UserControl
    {
        public ReceiverVideoMessage()
        {
            InitializeComponent();

            Avatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void OnLoad(string videoUrl)
        {
            Avatar.Hide();
            Video.URL = videoUrl;
        }

        public void OnLoad(string videoUrl, string avatar)
        {
            Avatar.ImageLocation = avatar;
            Video.URL = videoUrl;
        }
    }
}
