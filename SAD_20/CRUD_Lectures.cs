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
    public partial class CRUD_Lectures : Form
    {
        public CRUD_Lectures()
        {
            InitializeComponent();
        }

        private void CRUD_View_BTN_Lecture_Click(object sender, EventArgs e)
        {
            View_Lectures V = new View_Lectures();
            V.Show();
            this.Close();
        }

        private void CRUD_Create_BTN_Lecutre_Click(object sender, EventArgs e)
        {
            Create_Lecture C = new Create_Lecture();
            C.Show();
            this.Close();
        }

        private void CRUD_Update_BTN_Lecture_Click(object sender, EventArgs e)
        {
            Update_Lectures U = new Update_Lectures();
            U.Show();
            this.Close();

        }

        private void CRUD_Delete_BTN_Lecture_Click(object sender, EventArgs e)
        {
            Delete_Lecture D = new Delete_Lecture();
            D.Show();
            this.Close();
        }

        private void CRUD_Back_BTN_Lecture_Click(object sender, EventArgs e)
        {
            CEOMain cm = new CEOMain();
            cm.Show();
            this.Close();
        }

        private void CRUD_Lectures_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
