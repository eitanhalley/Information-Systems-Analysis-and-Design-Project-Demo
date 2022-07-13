using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class DeleteWorkshop : Form
    {
        private bool IsExist = false;
        public DeleteWorkshop()
        {
            InitializeComponent();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if (IDBox.Text == "")
            {
                MessageBox.Show("You must fill ID , please try again!");
            }
            if (!Regex.IsMatch(IDBox.Text, @"^\d+$"))
            {
                MessageBox.Show("ID must contain only numbers, please try again!");
            }
            else if (Program.seekWorkshop(Convert.ToInt32(IDBox.Text)) != null)
            {
                IsExist = true;
                Workshop w = Program.seekWorkshop(Convert.ToInt32(IDBox.Text));
                NameBox.Text = w.Get_name();
                DescriptionBox.Text = w.Get_descripton();
                StartDatePicker.Value = w.Get_startDate();
                EndDatePicker.Value = w.Get_EndDate();
                NumOfMeetingsBox.Text = w.get_NumOfMeetings().ToString();
                string[] substrings = w.Get_Repetivity().Split(' ');
                RepetivityBox.Text = substrings[2];
                RepetivityBox2.Text = " " + substrings[3];
                LocationBox.Text = w.Get_location();
                PriceBox.Text = w.Get_price().ToString();
                CapacityBox.Text = w.Get_capacity().ToString();
                SeatsLeftBox.Text = w.Get_seatsLeft().ToString();
                EmailBox.Text = w.Get_Email();
            }
            else
                MessageBox.Show("Could not find workshop , please try again!");

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(IsExist)
            {
                Workshop w = Program.seekWorkshop(Convert.ToInt32(IDBox.Text));
                w.delete_workshop();
                Program.init_workshops();
                closeForm();
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void closeForm()// close this form after Update
        {
            CRUD_Workshops c = new CRUD_Workshops();
            c.Show();
            this.Close();
        }

        private void DeleteWorkshop_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
