using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class ViewWorkshops_Client : Form
    {
        public ViewWorkshops_Client()
        {
            InitializeComponent();
        }

        private void ViewWorkshops_Client_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // TODO: This line of code loads data into the 'sAD_20DataSet.Get_all_workshops' table. You can move, or remove it, as needed.
            this.get_all_workshopsTableAdapter.Fill(this.sAD_20DataSet.Get_all_workshops);

        }

        private void lectureSearch_textBox_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt = this.sAD_20DataSet.Get_all_workshops;
            DataView dv = new DataView(dt);
            dv.RowFilter = "Name like '%" + WorkshopSearch_textBox.Text + "%'";
            dataGridView_Workshops.DataSource = dv;
        }

        private void closeForm()
        {
            ClientsMain c = new ClientsMain();
            this.Close();
            c.Show();
        }

        private void View_btn_Click(object sender, EventArgs e)
        {
            BookWorkshop_Clients b = new BookWorkshop_Clients(Convert.ToInt32(dataGridView_Workshops.SelectedCells[0].Value));
            this.Hide();
            b.Show();
        }

        private void back_button1_Click(object sender, EventArgs e)
        {
            closeForm();
        }


    }
}
