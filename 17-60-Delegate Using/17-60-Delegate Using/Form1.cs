namespace _17_60_Delegate_Using
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void fillTextBox(int x);
        string textvalue = "";
        public void fillMathNote(int examNote)
        {
            textvalue += "Your math note is: " + examNote + Environment.NewLine;
        }
        public void fillChemistryNote(int examNote)
        {
            textvalue += "Your Chemistry note is: " + examNote + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ShowInTextBox()
        {
            textBox1.Text = textvalue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillTextBox fillText = new fillTextBox(fillMathNote);
            fillText += fillChemistryNote;
            fillText(80);
            fillText -= fillMathNote;
            fillText(60);
            ShowInTextBox();
        }
    }
}