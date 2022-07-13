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
    public partial class UpdateClient : Form
    {
        public UpdateClient()
        {
            InitializeComponent();
            gender_comboBox.DataSource = Enum.GetValues(typeof(GenderType));
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

        private void UpdateClient_btn_Click(object sender, EventArgs e)
        {
            if (CheckList())
            {
                string fullName = FullName_textBox.Text;
                string email = Email_txtBox.Text;
                string phone = phone_textBox.Text;
                GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), gender_comboBox.SelectedItem.ToString());
                DateTime birthdate = birthdate_dateTimePicker.Value;
                string country = country_textBox.Text;
                string city = city_textBox.Text;
                Client c = Program.seekClient(Convert.ToString(Email_txtBox.Text));
                c.set_fullName(fullName);
                c.set_email(email);
                c.set_phone(phone);
                c.set_gender(gender);
                c.set_birthDate(birthdate);
                c.set_addressCountry(country);
                c.set_addressCity(city);
                c.update_client();
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


            /*foreach (Client c in Program.Clients)
            {

                if (c.get_email() == Email_txtBox.Text)
                {
                    MessageBox.Show("Client already exsits , please try again!");
                    return false;
                }

            }*/

            /*if (!NameValid(fullName_txtBox.Text))
            {
                MessageBox.Show("Please state full name!");
                return false;
            }*/


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


        private void back_btn_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void closeForm()
        {
            Clients_CRUD c = new Clients_CRUD();
            this.Close();
            c.Show();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
