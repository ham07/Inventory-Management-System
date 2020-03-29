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
    public partial class categories : Sample2
    {
        int edit = 0;//this 0 is indicates to save operation and 1 indicate for update operations
        int categoryID;
        short stat;
        retrieval r = new retrieval();
        public categories()
        {
            InitializeComponent();
        }
       
        private void categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(leftPanel);
            

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (categoryTxt.Text == "") { categoryErrorLabel.Visible = true; } else { categoryErrorLabel.Visible = false; }
            if (activeCB.SelectedIndex == -1) { activeErrorLabel.Visible = true; } else { activeErrorLabel.Visible = false; }
           
            if (categoryErrorLabel.Visible || activeErrorLabel.Visible)
            {
                MainClass.ShowMSG("Feild with * are mandatory", "Stop", "Error");//error is a type of message
            }
            else
            {

                if (activeCB.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (activeCB.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)//for save operations
                {

                    insertions i = new insertions();
                    i.insertCat(categoryTxt.Text, stat);
                    r.showCategories(dataGridView1, catIDGV, NameGV, stausGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1)// for update operations
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (activeCB.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (activeCB.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateCat(categoryID,categoryTxt.Text,  stat);
                        r.showCategories(dataGridView1, catIDGV, NameGV, stausGV);
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
                    d.deletecat(categoryID, " st_deleteCategory", "@id");
                    r.showCategories(dataGridView1, catIDGV, NameGV, stausGV);
                }

            }

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, catIDGV, NameGV, stausGV);
        }


       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                categoryID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                categoryTxt.Text = row.Cells["NameGV"].Value.ToString();
                activeCB.Text = row.Cells["stausGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
    
}
