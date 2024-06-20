namespace MilkTeaManagement.WindowsApp.UserControls.Chat.Self
{
    public partial class SelfVideoMessage : UserControl
    {
        public SelfVideoMessage()
        {
            InitializeComponent();
        }

        public void OnLoad(string videoUrl)
        {
            Video.URL = videoUrl;
        }
    }
}
