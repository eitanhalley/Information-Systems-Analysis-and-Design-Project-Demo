using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class ViewLectures_Client : Form
    {
        public ViewLectures_Client()
        {
            InitializeComponent();
        }

        private void ViewLectures_Client_Load_1(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // TODO: This line of code loads data into the 'sAD_20DataSet.Get_all_Lectures' table. You can move, or remove it, as needed.
            this.get_all_LecturesTableAdapter.Fill(this.sAD_20DataSet.Get_all_Lectures);

        }

        private void lectureSearch_textBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = this.sAD_20DataSet.Get_all_Lectures;
            DataView dv = new DataView(dt);
            dv.RowFilter = "Name like '%" + lectureSearch_textBox.Text + "%'";
            dataGridView_Lectures.DataSource = dv;
        }


        private void closeForm()
        {
            ClientsMain c = new ClientsMain();
            this.Close();
            c.Show();
        }

        private void back_button1_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void View_btn_Click(object sender, EventArgs e)
        {
            BookLecture_Clients b = new BookLecture_Clients(Convert.ToInt32(dataGridView_Lectures.SelectedCells[0].Value));
            this.Hide();
            b.Show();
        }
    }

}
