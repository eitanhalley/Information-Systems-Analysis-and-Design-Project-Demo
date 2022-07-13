using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class ViewClients : Form
    {
        public ViewClients()
        {
            InitializeComponent();
        }

        private void ViewClients_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // TODO: This line of code loads data into the 'sAD_20DataSet.Get_all_clients' table. You can move, or remove it, as needed.
            this.get_all_clientsTableAdapter.Fill(this.sAD_20DataSet.Get_all_clients);

        }

        private void clientSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = this.sAD_20DataSet.Get_all_clients;
            DataView dv = new DataView(dt);
            dv.RowFilter = "FullName like '%" + clientSearch.Text + "%'";
            dataGridView_Clients.DataSource = dv;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void closeForm()
        {
            Clients_CRUD c = new Clients_CRUD();
            this.Close();
            c.Show();
        }

        private void dataGridView_Clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
