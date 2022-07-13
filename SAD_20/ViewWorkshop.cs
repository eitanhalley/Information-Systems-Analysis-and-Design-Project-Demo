using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class ViewWorkshop : Form
    {
        public ViewWorkshop()
        {
            InitializeComponent();
        }

        private void ViewWorkshop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_20DataSet.Get_all_workshops' table. You can move, or remove it, as needed.
            //StyleGridView();
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.get_all_workshopsTableAdapter.Fill(this.sAD_20DataSet.Get_all_workshops);

        }

        void StyleGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = this.sAD_20DataSet.Get_all_workshops;
            DataView dv = new DataView(dt);
            dv.RowFilter = "Name like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CRUD_Workshops wc = new CRUD_Workshops();
            wc.Show();
            this.Close();
        }
    }
}
