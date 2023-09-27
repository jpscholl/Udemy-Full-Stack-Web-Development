namespace ListClassForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numberList = new List<int>();
        List<string> stringList = new List<string>();
        List<Employee> employeeList = new List<Employee>();

        List<days> comboList = new List<days>();

        public List<Employee> fillList()
        {
            employeeList.Clear();

            Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.Name = "Chadwick";
            employee1.Surname = "Chaddington Fancypants";
            employeeList.Add(employee1);

            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "Ricky";
            employee2.Surname = "Rickerson";
            employeeList.Add(employee2);

            Employee employee3 = new Employee();
            employee3.ID = 3;
            employee3.Name = "Bobby";
            employee3.Surname = "Bobberson";
            employeeList.Add(employee3);

            return employeeList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            days day1 = new days();
            day1.ID = 1;
            day1.textValue = "Sunday";
            comboList.Add(day1);

            days day2 = new days();
            day2.ID = 2;
            day2.textValue = "Monday";
            comboList.Add(day2);

            days day3 = new days();
            day3.ID = 3;
            day3.textValue = "Tuesday";
            comboList.Add(day3);

            days day4 = new days();
            day4.ID = 4;
            day4.textValue = "Wednesday";
            comboList.Add(day4);

            days day5 = new days();
            day5.ID = 5;
            day5.textValue = "Thursday";
            comboList.Add(day5);

            days day6 = new days();
            day6.ID = 6;
            day6.textValue = "Friday";
            comboList.Add(day6);

            comboList.Add(new days() { ID = 7, textValue = "Saturday" });

            cmbDays.DataSource = comboList;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "textvalue";

            daylist.DataSource = comboList;



        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            fillList();

            foreach (var item in employeeList)
            {
                txtNumber.Text += item.ID + " " + item.Name + " " + item.Surname + Environment.NewLine;
            }

            MessageBox.Show("List was filled");
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDays.SelectedValue.ToString());
        }
    }
}