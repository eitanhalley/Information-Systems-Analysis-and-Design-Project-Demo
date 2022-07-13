using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class CRUD_Workshops : Form
    {
        public CRUD_Workshops()
        {
            InitializeComponent();
        }


        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateWorkshop crw = new CreateWorkshop();
            crw.Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CEOMain cm = new CEOMain();
            cm.Show();
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateWorkshop wp = new UpdateWorkshop();
            wp.Show();
            this.Close();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewWorkshop v = new ViewWorkshop();
            v.Show();
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteWorkshop dw = new DeleteWorkshop();
            dw.Show();
            this.Close();
        }

        private void CRUD_Workshops_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
