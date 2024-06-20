namespace MilkTeaManagement.WindowsApp.UserControls.Chat.Self
{
    public partial class SelfImageMessage : UserControl
    {
        public SelfImageMessage()
        {
            InitializeComponent();
        }

        public void OnLoad(string imageUrl)
        {
            Image.ImageLocation = imageUrl;
        }
    }
}
