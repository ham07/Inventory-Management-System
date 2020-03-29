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
    public partial class Suppliers : Sample2
    {
        int edit = 0;
        int supplierID;
        short stat;
        public Suppliers()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }
        private void Suppliers_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (supplierCompantTxt.Text == "") { suppliernameErrorLabel.Visible = true; } else { suppliernameErrorLabel.Visible = false; }
            if (personNameTxt.Text == "") { personErrorLabel.Visible = true; } else { personErrorLabel.Visible = false; }
            if (Phone1Txt.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (addressTxt.Text == "") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            //-1 is equal to blank
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (suppliernameErrorLabel.Visible || personErrorLabel.Visible || phoneErrorLabel.Visible || addressErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Feild with * are mandatory", "Stop", "Error");//error is a type of message
            }
            else
            {

                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)//for save operations
                {

                    insertions i = new insertions();
                    if (Phone2Txt.Text == "" && ntnTxt.Text != "")
                    {
                        i.insertSuppliers(supplierCompantTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                    }
                    else if (Phone2Txt.Text != "" && ntnTxt.Text == "")
                    {
                        i.insertSuppliers(supplierCompantTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, Phone2Txt.Text, null);
                    }
                    else if (Phone2Txt.Text == "" && ntnTxt.Text == "")
                    {
                        i.insertSuppliers(supplierCompantTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, null);
                    }
                    else
                    {
                        i.insertSuppliers(supplierCompantTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, Phone2Txt.Text, ntnTxt.Text);
                    }

                    r.showSuppliers(dataGridView1, supIDGV, comNameGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, stausGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1)// for update operations
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        if (Phone2Txt.Text == "" && ntnTxt.Text != "")
                        {
                            u.updateSuppliers(supplierID, supplierCompantTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                        }
                        else if (Phone2Txt.Text != "" && ntnTxt.Text == "")
                        {
                            u.updateSuppliers(supplierID, supplierCompantTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, Phone2Txt.Text, null);
                        }
                        else if (Phone2Txt.Text == "" && ntnTxt.Text == "")
                        {
                            u.updateSuppliers(supplierID, supplierCompantTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, null);
                        }
                        else
                        {
                            u.updateSuppliers(supplierID, supplierCompantTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, Phone2Txt.Text, ntnTxt.Text);
                        }



                        r.showSuppliers(dataGridView1, supIDGV, comNameGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, stausGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure , you want to delete record?", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    deletion d = new deletion();
                    d.deletesup(supplierID, " st_deleteSuppliers", "@suppID");
                    r.showSuppliers(dataGridView1, supIDGV, comNameGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, stausGV);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showSuppliers(dataGridView1, supIDGV, comNameGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, stausGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = 1;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            supplierID = Convert.ToInt32(row.Cells["supIDGV"].Value.ToString());
            supplierCompantTxt.Text = row.Cells["comNameGV"].Value.ToString();
            personNameTxt.Text = row.Cells["personGV"].Value.ToString();
            Phone1Txt.Text = row.Cells["phone1GV"].Value.ToString();
            Phone2Txt.Text = row.Cells["phone2GV"].Value.ToString();
            addressTxt.Text = row.Cells["addressGV"].Value.ToString();
            ntnTxt.Text = row.Cells["ntnGV"].Value.ToString();
            statusDD.Text = row.Cells["stausGV"].Value.ToString();
            MainClass.disable(leftPanel);
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
