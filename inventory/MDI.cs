using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace inventory
{
    //partial is a class that breaks into parts
    //MDI stands for
    // multiple dcoument interface
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path + "\\connec"))
            {
                login log = new login();
               MainClass.showWindow(log, this);
            }
            else
            {
                settings set = new settings();
                MainClass.showWindow(set, this);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            MainClass.showWindow(set, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.logoutToolStripMenuItem.Enabled = false;
            login set = new login();
            MainClass.showWindow(set, this);


        }
    }
}
