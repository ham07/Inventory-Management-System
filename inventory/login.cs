using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passTxt.Text == "") { passErrorlabel.Visible = true; } else { passErrorlabel.Visible = false; }
            if (usernameErrorLabel.Visible || passErrorlabel.Visible)
            {
                MainClass.ShowMSG("Feild with * are mandatory", "Stop", "Error");//error is a type of message
            }
            else
            {

                if (retrieval.getUserDetails(usernameTxt.Text, passTxt.Text))
                {
                    HomeScreen obj = new HomeScreen();
                    MainClass.showWindow(obj, this, MDI.ActiveForm);

                }
                else
                {

                }

            }

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            if (passTxt.Text == "") { passErrorlabel.Visible = true; } else { passErrorlabel.Visible = false; }
        }

        private void passTxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usernameErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void passErrorlabel_Click(object sender, EventArgs e)
        {

        }
    }
    }

