using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class BookWorkshop_Clients : Form
    {
        public BookWorkshop_Clients(int value)
        {
            InitializeComponent();
            IDLecture.Text = value.ToString();
        }

        private void BookWorkshop_Clients_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Workshop w = Program.seekWorkshop(Convert.ToInt32(IDLecture.Text));
            name_lbl.Text = w.Get_name().ToString();
            description_txtBox.Text = w.Get_descripton().ToString();
            txtPrice_Update_Lectures.Text = w.Get_price().ToString();
            DatePicker.Text = w.Get_startDate().ToString();
            txtCapacity_Update_Lectures.Text = w.Get_capacity().ToString();
            txtLocation_Update_Lectures.Text = w.Get_location().ToString();
            txtSeats_Update_Lectures.Text = w.Get_seatsLeft().ToString();
            txtEmail_Update_Lectures.Text = w.Get_Email();
            RepetivityBox.Text = w.Get_Repetivity();
            numOfMeeting_txtBox.Text = w.get_NumOfMeetings().ToString();

        }

        private void Cancel_Lecture_BTN_Click(object sender, EventArgs e)
        {
            ViewWorkshops_Client vw = new ViewWorkshops_Client();
            this.Close();
            vw.Show();
        }
    }
}
