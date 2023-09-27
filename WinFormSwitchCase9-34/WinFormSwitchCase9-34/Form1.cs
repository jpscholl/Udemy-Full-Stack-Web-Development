using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSwitchCase9_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwitchCase_Click(object sender, EventArgs e)
        {

            string messageText = "";
            switch (Convert.ToInt32(textBox1.Text))
            {
                case 2:
                    messageText = "x = 2";
                    break;
                case 4:
                    messageText = "x = 4";
                    break;
                case 6:
                    messageText = "x = 6";
                    switch (Convert.ToInt32(textBox2.Text))
                    {
                        case 1:
                            messageText += " y = 1";
                            break;
                        case 2:
                            messageText += " y = 2";
                            break;
                        default:
                            messageText += " y = 3";
                            break;
                    }
                    break;
                default:
                    messageText = "x = 8";
                    break;
            }

            MessageBox.Show(messageText);
        }
    }
}
