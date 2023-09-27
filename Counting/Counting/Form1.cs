using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //variables
        int firstNumber = 0;
        int lastNumber = 0;
        int divisibleTerm = 1;


        //event for Count button
        private void btnCount_Click(object sender, EventArgs e)
        {
            string divisibleNumber = "";
            if (txtStartFrom.Text.Trim() == "" || txtTo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the neccessary fields");
            }
            else if (cmbDivisible.SelectedIndex == -1)
            {
                MessageBox.Show("Please select divisible term");
            }
            else
            {
                firstNumber = Convert.ToInt32(txtStartFrom.Text);
                lastNumber = Convert.ToInt32(txtTo.Text);
                MessageBox.Show("Divisible " + divisibleTerm + " From " + firstNumber + " to " + lastNumber);

                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumber += i.ToString() + " ";
                        if (controlNumber % 10 == 0)
                            divisibleNumber += Environment.NewLine;
                        controlNumber++;
                    }
                }
                txtDivisibleNumbers.Text = divisibleNumber;
            }

        }

        private void cmbDivisible_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisible.SelectedItem);
        }
        int controlNumber = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisible.Items.Add("2");
            cmbDivisible.Items.Add("3");
            cmbDivisible.Items.Add("4");
            cmbDivisible.Items.Add("5");
            cmbDivisible.Items.Add("6");
            cmbDivisible.Items.Add("7");
            cmbDivisible.Items.Add("8");
            cmbDivisible.Items.Add("10");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDivisibleNumbers.Text = "";
        }

        private void txtStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlack.Checked)
            {
                rdRed.Checked = false;
                rdGreen.Checked = false;
                rdBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Black;
            }
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlue.Checked)
            {
                rdRed.Checked = false;
                rdGreen.Checked = false;
                rdBlack.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Blue;

            }
        }

        private void rdRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRed.Checked)
            {
                rdBlack.Checked = false;
                rdGreen.Checked = false;
                rdBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGreen.Checked)
            {
                rdRed.Checked = false;
                rdBlack.Checked = false;
                rdBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Green;

            }
        }

        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBold.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Bold);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Italic);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }
    }
}
