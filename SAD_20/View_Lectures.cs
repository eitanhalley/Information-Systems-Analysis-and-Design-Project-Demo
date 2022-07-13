using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class View_Lectures : Form
    {
        public View_Lectures()
        {
            InitializeComponent();
        }

        private void View_Lectures_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // TODO: This line of code loads data into the 'sAD_20DataSet.Get_all_Lectures' table. You can move, or remove it, as needed.
            this.get_all_LecturesTableAdapter.Fill(this.sAD_20DataSet.Get_all_Lectures);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = this.sAD_20DataSet.Get_all_Lectures;
            DataView dv = new DataView(dt);
            dv.RowFilter = "Name like '%" + txtSearch.Text + "%'";
            dataGridViewLectures.DataSource = dv;
        }

        private void Close_View_Lectures_BTN_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void closeForm()// close this form after Update
        {
            CRUD_Lectures c = new CRUD_Lectures();
            c.Show();
            this.Close();
        }

        void StyleGridView()
        {
            dataGridViewLectures.BorderStyle = BorderStyle.None;
            dataGridViewLectures.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewLectures.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewLectures.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewLectures.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewLectures.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewLectures.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewLectures.EnableHeadersVisualStyles = false;
            dataGridViewLectures.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewLectures.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewLectures.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
