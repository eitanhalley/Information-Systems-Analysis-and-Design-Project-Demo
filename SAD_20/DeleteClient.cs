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
    public partial class DeleteClient : Form
    {
        public DeleteClient()
        {
            InitializeComponent();
        }

        static Regex ValidEmailRegex = CreateValidEmailRegex();
        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }
        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }


        private void SearchClient_btn_Click(object sender, EventArgs e)
        {
            if (Email_txtBox.Text == "")
            {
                MessageBox.Show("Please fill client's email");
            }
            else if (Program.seekClient(Convert.ToString(Email_txtBox.Text)) != null)
            {
                Client c = Program.seekClient(Convert.ToString(Email_txtBox.Text));
                FullName_textBox.Text = c.get_name();
                phone_textBox.Text = c.get_phone();
                gender_comboBox.Text = c.get_gender().ToString();
                birthdate_dateTimePicker.Value = c.get_birthDate();
                country_textBox.Text = c.get_addressCountry();
                city_textBox.Text = c.get_addressCity();
            }
            else
                MessageBox.Show("Client is not found, please try again!");
        }


        private void DeleteClient_btn_Click(object sender, EventArgs e)
        {
            if (CheckList())
            {
                Client c = Program.seekClient(Convert.ToString(Email_txtBox.Text));
                c.delete_client();
                Program.init_clients();
                closeForm();
            }
        }

        public bool CheckList()
        {

            if (!checkInserted())
            {
                MessageBox.Show("You must fill all Boxes , please try again!");
                return false;
            }

            if (!EmailIsValid(Email_txtBox.Text))
            {
                MessageBox.Show("Your Email Input is no vaild , please try again !");
                return false;
            }
            return true;
        }

        private bool checkInserted()
        {
            if (FullName_textBox.Text == "")
            {
                return false;
            }
            if (Email_txtBox.Text == "")
            {
                return false;
            }
            if (phone_textBox.Text == "")
            {
                return false;
            }
            if (gender_comboBox.Text == "")
            {
                return false;
            }
            if (birthdate_dateTimePicker.Text == "")
            {
                return false;
            }

            if (country_textBox.Text == "")
            {
                return false;
            }
            if (city_textBox.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void closeForm()
        {
            Clients_CRUD c = new Clients_CRUD();
            this.Close();
            c.Show();
        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            closeForm();
        }

        private void DeleteClient_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
