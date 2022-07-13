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
    public partial class Clients_CRUD : Form
    {
        public Clients_CRUD()
        {
            InitializeComponent();
        }

        private void Clients_CRUD_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void createNewClient_btn_Click(object sender, EventArgs e)
        {
            CreateNewClient c = new CreateNewClient();
            this.Hide();
            c.Show();

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            CEOMain c = new CEOMain();
            this.Hide();
            c.Show();
        }

        private void updateClient_btn_Click(object sender, EventArgs e)
        {
            UpdateClient u = new UpdateClient();
            this.Hide();
            u.Show();
        }

        private void DeleteClient_btn_Click(object sender, EventArgs e)
        {
            DeleteClient u = new DeleteClient();
            this.Hide();
            u.Show();
        }

        private void ViewClients_btn_Click(object sender, EventArgs e)
        {
            ViewClients v = new ViewClients();
            this.Hide();
            v.Show();
        }
    }
}
