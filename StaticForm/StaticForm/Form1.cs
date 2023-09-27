namespace StaticForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student.StudentNumber = 1;
            Student.getAddNote();
        }
    }
}