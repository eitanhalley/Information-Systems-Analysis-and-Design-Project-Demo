using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class AboutCEO : Form
    {
        public AboutCEO()
        {
            InitializeComponent();
            CEO c = Program.CEOS[0];
            About_richTextBox.Text = c.get_aboutCEO().ToString();
        }


        private void closeForm()
        {
            ClientsMain c = new ClientsMain();
            this.Close();
            c.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            closeForm();
        }
    }
}
