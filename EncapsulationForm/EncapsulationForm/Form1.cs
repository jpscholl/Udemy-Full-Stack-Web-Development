namespace EncapsulationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employeeDetails = new Employee();
            employeeDetails.EmployeeName = txtEmployeeName.Text;
            employeeDetails.EmployeeAge = Convert.ToInt32(txtEmployeeAge.Text);
            employeeDetails.EmployeePosition = txtEmployeePosition.Text;
            FrmEmployeeDetails frm = new FrmEmployeeDetails();
            frm.label1.Text = txtEmployeeName.Text;
            frm.label2.Text = txtEmployeeAge.Text;
            frm.label3.Text = txtEmployeePosition.Text;
            frm.ShowDialog();
        }
    }
}