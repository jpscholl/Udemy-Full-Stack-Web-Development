namespace InheritanceForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues();
            teacher.SetValues2();
            teacher.FindSalary();
            string allvalues = "";
            allvalues += teacher.Name + Environment.NewLine;
            allvalues += teacher.Gender + Environment.NewLine;
            allvalues += teacher.Age + Environment.NewLine;
            allvalues += teacher.Branch + Environment.NewLine;
            allvalues += teacher.Salary + Environment.NewLine;
            textBox1.Text = allvalues;


        }
    }
}