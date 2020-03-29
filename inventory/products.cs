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
    public partial class products : Sample2
    {
        int edit = 0;//this 0 is indicates to save operation and 1 indicate for update operations
        Int64 proID;
        
        public products()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.getList("st_getCategoryList", categoryCB, "Category", "ID");
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
            if (proTxt.Text == "") { proErrorLabel.Visible = true; } else { proErrorLabel.Visible = false; }
            if (barTxt.Text == "") { barErrorLabel.Visible = true; } else { barErrorLabel.Visible = false; }
            if (dateTimePicker.Value < DateTime.Now) { expErrorLabel.Visible = true; expErrorLabel.Text = "Invalid date"; } else { expErrorLabel.Visible = false; }

            
            //-1 is equal to blank
            if (categoryCB.SelectedIndex == -1 || categoryCB.SelectedIndex == 0) { categoryErrorLabel.Visible = true; } else { categoryErrorLabel.Visible = false; }

            if (proErrorLabel.Visible || barErrorLabel.Visible || expErrorLabel.Visible)
            {
                MainClass.ShowMSG("Feild with * are mandatory", "Stop", "Error");//error is a type of message
            }
            else
            {

             
                if (edit == 0)//for save operations
                {

                    insertions i = new insertions();
                    if (dateTimePicker.Value.Date == DateTime.Now.Date)
                    {
                        i.insertproducts(proTxt.Text, barTxt.Text, Convert.ToInt32(categoryCB.SelectedValue));
                    }
                    else
                    {
                        i.insertproducts(proTxt.Text, barTxt.Text, Convert.ToInt32(categoryCB.SelectedValue),dateTimePicker.Value);
                    }
                   
                    r.showProduct(dataGridView1, proIDGV, proNameGV, expiryGV,  catGV, barcodeGV, catIDGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1)// for update operations
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (dateTimePicker.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProducts(proID, proTxt.Text, barTxt.Text, Convert.ToInt32(categoryCB.SelectedValue));
                        }
                        else
                        {
                            u.updateProducts(proID, proTxt.Text, barTxt.Text, Convert.ToInt32(categoryCB.SelectedValue),dateTimePicker.Value);
                        }
                       
                        r.showProduct(dataGridView1, proIDGV, proNameGV, barcodeGV, expiryGV,  catGV, catIDGV);
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
                    d.deleteProducts(proID, "st_productDelete", "@proID");
                    r.showProduct(dataGridView1, proIDGV, proNameGV, expiryGV,  catGV, barcodeGV, catIDGV);
                }

            }

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showProduct(dataGridView1, proIDGV, proNameGV, expiryGV, barcodeGV,  catGV, catIDGV);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    edit = 1;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    proID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                    proTxt.Text = row.Cells["proNameGV"].Value.ToString();
                    barTxt.Text = row.Cells["barcodeGV"].Value.ToString();
                    //if (row.Cells["expiryGV"].FormattedValue.ToString() == "")
                    //{
                    //    dateTimePicker.Value = DateTime.Now;
                    //}
                    //else
                    //{
                    //    dateTimePicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());

                    //}
                    categoryCB.SelectedItem = row.Cells["catIDGV"].Value.ToString();

                    MainClass.disable(leftPanel);
                }
            
            
        
        }

       
    }
}
