using ClockLib;
using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ClockWinFormApp
{
    public partial class Clock_form : Form
    {
        IClock clock = new ClockLib.Clock();
        Bitmap bitmap;

        float hourAngle, minuteAngle, secondAngle;

        public Clock_form()
        {
            InitializeComponent();
            Timer();
            ClockAngle();
        }

        // One second updating timer.
        private void Timer()
        {
            System.Windows.Forms.Timer timer;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Clock_timer_Tick;
            timer.Start();
        }

        // Getting angle of clock.
        private void ClockAngle()
        {
            int getHour = clock.Time.Hour % 12;
            int getMinute = clock.Time.Minute;
            int getSecond = clock.Time.Second;

            hourAngle = getHour * 30 + getMinute * 0.5f;
            minuteAngle = getMinute * 6 + getSecond * 0.1f;
            secondAngle = getSecond * 6;

            GetClockPicture();
        }

        // Placing Drawhand in the center.
        private void Drawhand(Graphics graphics, float angle, int height, int width, Color color)
        {
            graphics.TranslateTransform(bitmap.Width / 2, bitmap.Height / 2);
            graphics.RotateTransform(angle);
            using (Pen pen = new Pen(color, width))
            {
                graphics.DrawLine(pen, 0, 15, 0, -height);
            }

            graphics.ResetTransform();
        }

        // Drawhand length and thickness adjustment.
        private void GetClockPicture()
        {
            bitmap = new Bitmap(Clock_pictureBox.Width, Clock_pictureBox.Height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {

                Drawhand(graphics, minuteAngle, Clock_pictureBox.Height / 2 - 120, 6, Color.Black);
                Drawhand(graphics, hourAngle, Clock_pictureBox.Height / 4 - 20, 6, Color.Blue);
                Drawhand(graphics, secondAngle, Clock_pictureBox.Height / 2 - 120, 2, Color.Red);
            }
        }

        // Drawhand moving.
        private void Clock_timer_Tick(object sender, EventArgs e)
        {
            ClockAngle();
            Clock_pictureBox.Invalidate();
        }

        // Create clock image.
        private void Clock_pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, new Rectangle(0, 0, Clock_pictureBox.Width, Clock_pictureBox.Height));
        }
    }
}
