﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_Project
{
    public partial class watchOrders : Form
    {
        public watchOrders()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainForm f = new mainForm();
            f.Show();
            this.Hide();
        }
    }
}
