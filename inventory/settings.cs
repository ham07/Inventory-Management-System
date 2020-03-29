using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
                string s;
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (isCB.Checked)
                {
                    if (serverTxt.Text != "" && databaseTxt.Text != "")

                    {
                    //we use MultipleActiveResultSets for excecuting multiple query in same connection 
                    s = "Data Source=" + serverTxt.Text + ";Database=" + databaseTxt.Text + ";Integrated Security = true;MultipleActiveResultSets=true;";
                        File.WriteAllText(path + "\\connec", s);
                    DialogResult dr = MessageBox.Show("Settings save successfully....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                    else
                    {
                        MessageBox.Show("please give complete data to continue");
                    }

                }
                else
                {
                    if (serverTxt.Text != "" && databaseTxt.Text != "" && userTxt.Text != "" && passTxt.Text != "")


                    {
                        s = "Data Source=" + serverTxt.Text + ";Database=" + databaseTxt.Text + ";uid=" + userTxt.Text + "; password=" + passTxt.Text + ";MultipleActiveResultSets=true;";
                        File.WriteAllText(path + "\\connec", s);
                        DialogResult dr = MessageBox.Show("Settings save successfully....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            login log = new login();
                            MainClass.showWindow(log, this, MDI.ActiveForm);
                        }
                    }
                    else
                    {
                        MessageBox.Show("please give complete data to continue");
                    }
                }


            
           
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userTxt.Enabled = false;
                passTxt.Enabled = false;
                userTxt.Text = "";
                passTxt.Text = "";
            }
            else
            {
                userTxt.Enabled = true;
                passTxt.Enabled = true;
            }

        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void databaseTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void serverTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
