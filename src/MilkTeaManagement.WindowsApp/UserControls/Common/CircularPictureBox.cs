using System.Drawing.Drawing2D;

namespace MilkTeaManagement.WindowsApp.UserControls.Common
{
    public class CircularPictureBox : PictureBox
    {
        public CircularPictureBox()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            SizeMode = PictureBoxSizeMode.Zoom;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, Width - 1, Height - 1);
                Region = new Region(gp);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(BackColor), 1), 0, 0, Width - 1, Height - 1);
            }
        }
    }
}
