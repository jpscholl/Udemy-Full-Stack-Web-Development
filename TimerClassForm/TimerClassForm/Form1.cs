namespace TimerClassForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = counter;
            counter--;
            label1.Text = counter.ToString();
            if (counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("Timer stopped.");
            }

            if (counter % 2 == 1)
                button1.BackColor = Color.Red;
            else
                button1.BackColor = Color.White;
        }

        int counter = 60;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = 60.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}