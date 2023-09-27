using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee personelDetail = new Employee();
            personelDetail.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            personelDetail.Name = txtEmployeeName.Text;
            personelDetail.Age = Convert.ToInt32(txtEmployeeAge.Text);
            MessageBox.Show("All Data Received");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee personelDetail = new Employee();
            personelDetail.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            personelDetail.Name = txtEmployeeName.Text;
            personelDetail.Age = Convert.ToInt32(txtEmployeeAge.Text);
            Form2 frm=new Form2();
            frm.personelDetail = personelDetail;
            frm.ShowDialog();
        }
    }
}
