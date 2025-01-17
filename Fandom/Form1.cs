﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initDB();
        }
        private void initDB()
        {
            DBWork.FillQueryes();
            DBWork.MakeQuery();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            //DataSet ds = DataProcesing.AddData();
            //dgrTable.DataSource = DataProcesing.AddData().Tables[0];
            dgrTable.DataSource = DataProcesing.GetDBData().Tables[0];
            dgrTable.Refresh();
        }
    }
}
