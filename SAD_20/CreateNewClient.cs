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
    public partial class CreateNewClient : Form
    {
        public CreateNewClient()
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

        static Regex ValidNameRegex = CreateValidNameRegex();
        private static Regex CreateValidNameRegex()
        {
            string ValidNameRegex = @"[^a-zA-Z\s]";

            return new Regex(ValidNameRegex, RegexOptions.IgnoreCase);
        }
/*        internal static bool NameValid(string name)
        {
            bool isValid = ValidNameRegex.IsMatch(name);

            return isValid;
        }*/

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }

        private void CreateNewClient_btn_Click(object sender, EventArgs e)
        {
            if (CheckList())
            {
                string fullName = fullName_txtBox.Text;
                string email = Email_txtBox.Text;
                string phone = phone_textBox.Text;
                GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), gender_comboBox.SelectedItem.ToString()); //how to do 
                DateTime birthdate = birthdate_dateTimePicker.Value;
                string country = country_textBox.Text;
                string city = city_textBox.Text;
                Client client = new Client(fullName, email, phone, gender, birthdate, country, city,"1234");
                client.create_client();
                Program.init_clients();
            }

            closeForm();
            
        }

        public bool CheckList()
        {

            if (!checkInserted())
            {
                MessageBox.Show("You must fill all Boxes , please try again!");
                return false;
            }


            foreach (Client c in Program.Clients)
            {

                if (c.get_email() == Email_txtBox.Text)
                {
                    MessageBox.Show("Client already exsits , please try again!");
                    return false;
                }

            }
           
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
            if (fullName_txtBox.Text == "")
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
             

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void CreateNewClient_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
