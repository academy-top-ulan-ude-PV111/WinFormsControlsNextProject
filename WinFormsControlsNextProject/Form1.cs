namespace WinFormsControlsNextProject
{
    public partial class Form1 : Form
    {
        int value = 0;
        public Form1()
        {
            InitializeComponent();
            //timer1.Start();
            //for(int i = 0; i < 7; i++)
            //    monthCalendar1.AddMonthlyBoldedDate(DateTime.Now.AddDays(i));
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //label1.Text = "Track value = " + trackBar1.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if(progressBar1.Value < progressBar1.Maximum)
            //    progressBar1.Value += 5;
            //progressBar1.PerformStep();
            label1.Text = (++value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            else
                timer1.Start();
        }
    }
}