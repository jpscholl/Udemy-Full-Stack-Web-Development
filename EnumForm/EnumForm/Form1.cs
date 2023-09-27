namespace EnumForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum colors {red = 1, blue, white, black, yellow, purple, brown, orange };

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var color in Enum.GetValues(typeof(colors)))
            {
                textBox1.Text +=(int)color + "- " + color.ToString() + Environment.NewLine;
            }
        }
    }
}