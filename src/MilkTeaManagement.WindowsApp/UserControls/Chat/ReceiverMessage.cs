namespace MilkTeaManagement.WindowsApp.UserControls.Chat
{
    public partial class ReceiverMessage : UserControl
    {
        public ReceiverMessage()
        {
            InitializeComponent();
        }

        public void OnLoad(string message)
        {
            Avatar.Hide();
            Message.Text = message;
            Size size = TextRenderer.MeasureText(Message.Text, Message.Font, Message.ClientSize, TextFormatFlags.WordBreak);
            Message.Height = size.Height;
        }

        public void OnLoad(string message, string avatar)
        {
            Avatar.ImageLocation = avatar;
            Message.Text = message;
            Size size = TextRenderer.MeasureText(Message.Text, Message.Font, Message.ClientSize, TextFormatFlags.WordBreak);
            Message.Height = size.Height;
        }
    }
}
