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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            Worker emp = Program.seekWorker(id.Text);
            if (emp != null)
            {
                //ceo id - 1111

                if (password.Text.Equals("1234"))
                {
                    if (id.Text.Equals("1111"))
                    {
                        CRUD f = new CRUD();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        CRUD f = new CRUD();
                        f.Show();
                        this.Hide();
                    }

                }
            }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            moadA ma = new moadA();
            ma.Show();
            this.Hide();
            
        }
    }
}
