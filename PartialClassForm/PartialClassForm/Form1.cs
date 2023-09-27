namespace PartialClassForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public partial class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }

        }

        public partial class Employee
        {
            public void SetValues()
            {
                Name = "Jon";
                EmployeeID = 1;
                Salary = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public sealed class sealedClass
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.SetValues();

            textBox1.Text = emp.EmployeeID.ToString() + Environment.NewLine
                + emp.Name + Environment.NewLine
                + emp.Salary + Environment.NewLine;
        }
    }
}