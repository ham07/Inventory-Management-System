﻿using System;
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
    public partial class Reciept : Form
    {
        public Reciept()
        {
            InitializeComponent();
        }

        private void Reciept_Load(object sender, EventArgs e)
        {
            retrieval r = new retrieval();
            r.showReport(crystalReportViewer1, "st_getSalesRecipt", "@user", retrieval.User_ID);
        }
    }
}
