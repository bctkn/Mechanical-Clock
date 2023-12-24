using ClockLib;

namespace ClockWinFormApp
{
    public partial class Clock_form : Form
    {
        System.Windows.Forms.Timer timer;

        public Clock_form()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // One second updating time.
            timer.Tick += Clock_timer_Tick;
            timer.Start();
        }

        private void Clock_timer_Tick(object sender, EventArgs e)
        {

        }

        private void Clock_pictureBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
