using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_Project
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            Create f = new Create();
            f.Show();
            this.Hide();
        }

        private void button_exist_Click(object sender, EventArgs e)
        {
            UpdateDelete f = new UpdateDelete();
            f.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainForm f = new mainForm();
            f.Show();
            this.Hide();
        }
    }
}
