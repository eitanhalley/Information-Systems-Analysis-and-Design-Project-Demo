using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class Delete_Lecture : Form
    {
        public Delete_Lecture()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Lecture_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Search_BTN_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("You must fill ID , please try again!");
            }
            if (!Regex.IsMatch(txtID.Text, @"^\d+$"))
            {
                MessageBox.Show("ID must contain only numbers, please try again!");
            }
            else if (Program.seekLecture(Convert.ToInt32(txtID.Text)) != null)
            {
                Lecture L = Program.seekLecture(Convert.ToInt32(txtID.Text));
                txtDuration.Text = L.Get_duration().ToString();
                txtType.Text = L.Get_lectureType().ToString();
                txtEmail.Text = L.Get_email().ToString();
                txtName.Text = L.Get_name().ToString();
                txtDescription.Text = L.Get_descripton().ToString();
                txtPrice.Text = L.Get_price().ToString();
                PickerStart.Value = L.Get_startDate();
                TimePicker.Value = L.Get_startDate();
                txtCapacity.Text = L.Get_capacity().ToString();
                txtLocation.Text = L.Get_location().ToString();
                txtSeats.Text = L.Get_seatsLeft().ToString();
            }
            else
                MessageBox.Show("Lecture Not Found , please try again!");
        }

        private void Delete_BTN_Click(object sender, EventArgs e)
        {
            Lecture L = Program.seekLecture(Convert.ToInt32(txtID.Text));
            L.delete_lecture();
            Program.init_lectures();

            closeForm();
        }


        private void closeForm()// close this form after Update
        {
            CRUD_Lectures c = new CRUD_Lectures();
            c.Show();
            this.Close();
        }

        private void Close_BTN_Click(object sender, EventArgs e)
        {
            closeForm();
        }
    }
}
