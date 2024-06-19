namespace MilkTeaManagement.WindowsApp.UserControls.Chat
{
    public partial class SelfMessage : UserControl
    {
        public SelfMessage()
        {
            InitializeComponent();
        }

        public void OnLoad(string message)
        {
            Message.Text = message;
            Size size = TextRenderer.MeasureText(Message.Text, Message.Font, Message.ClientSize, TextFormatFlags.WordBreak);
            Message.Height = size.Height;
        }
    }
}
