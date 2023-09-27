namespace RandomClassForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            byte[] Array = new byte[5];
            rnd.NextBytes(Array);
            label1.Text = Array[0].ToString();
            label2.Text = Array[1].ToString();
            label3.Text = Array[2].ToString();
            label4.Text = Array[3].ToString();
            label5.Text = Array[4].ToString();

        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string allCharacters = "0123456789" +
                      "abcdefghijklmnopqrstuvwxyz" +
                      "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                      "!@#$%^&*()-_=+[]{}|;:'\",.<>/?\\";
            string result = "";
            Random rnd2 = new Random();
            for (int i = 0; i < 6; i++)
            {
                result += allCharacters[rnd2.Next(0, Convert.ToInt32(allCharacters.Length))];
            }

            label1.Text = result;
        }
    }
}