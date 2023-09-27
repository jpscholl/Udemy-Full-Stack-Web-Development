using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string messageTitle = "Greetings!";
            string messageText = "Hello there good sir/madam!";


            MessageBox.Show(messageText, messageTitle);
            MessageBox.Show("This is another way to show this box", "Howdy");


            string message2 = "Do you want to close window?";
            string title2 = "Close window";

            MessageBoxButtons button2 = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message2, title2, button2);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else if(result == DialogResult.No)
            {
                //nothing
            }

            string message3 = "Did you see icon?";
            string title3 = "ok";
            MessageBox.Show(message3, title3, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
