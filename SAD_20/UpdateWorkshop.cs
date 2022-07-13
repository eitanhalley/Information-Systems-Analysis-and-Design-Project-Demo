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
    public partial class UpdateWorkshop : Form
    {
        public UpdateWorkshop()
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

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if(IDBox.Text == "")
            {
                MessageBox.Show("You must fill ID , please try again!");
            }
            if(!Regex.IsMatch(IDBox.Text, @"^\d+$"))
            {
                MessageBox.Show("ID must contain only numbers, please try again!");
            }

            else if(Program.seekWorkshop(Convert.ToInt32(IDBox.Text)) != null)
            {
                Workshop w = Program.seekWorkshop(Convert.ToInt32(IDBox.Text));
                NameBox.Text = w.Get_name();
                DescriptionBox.Text = w.Get_descripton();
                StartDatePicker.Value = w.Get_startDate();
                TimePicker.Value = w.Get_startDate();
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
                MessageBox.Show("Could not find this workshop, please try again!");
        }


        public bool CheckList()
        {

            if (!checkInserted())
            {
                MessageBox.Show("You must fill all details, please try again!");
                return false;
            }


            if (Convert.ToDouble(PriceBox.Text) < 0)
            {
                MessageBox.Show("Price is invaild , please try again !");
                return false;
            }


            if (!EmailIsValid(EmailBox.Text))
            {
                MessageBox.Show("Your Email Input unvaild , please try again !");
                return false;
            }

            if (!IsAvailableDate())
            {
                MessageBox.Show("Your date is unavailable , please try again !");
                return false;
            }

            if (Convert.ToInt32(NumOfMeetingsBox.Text) <= 0)
            {
                MessageBox.Show("Num of meetings should be greater than 0 , please try again !");
                return false;
            }

            if (Convert.ToInt32(CapacityBox.Text) <= 0)
            {
                MessageBox.Show("Capacity is invalid , please try again !");
                return false;
            }

            if (Convert.ToInt32(SeatsLeftBox.Text) < 0 || Convert.ToInt32(SeatsLeftBox.Text) > Convert.ToInt32(CapacityBox.Text))
            {
                MessageBox.Show("Seats left is invalid , please try again !");
                return false;
            }



            return true;
        }

        private bool checkInserted()
        {
            if (NameBox.Text == "")
            {
                return false;
            }
            if (IDBox.Text == "")
            {
                return false;
            }
            if (PriceBox.Text == "")
            {
                return false;
            }
            if (RepetivityBox.Text == "")
            {
                return false;
            }
            if (LocationBox.Text == "")
            {
                return false;
            }

            if (DescriptionBox.Text == "")
            {
                return false;
            }
            if (CapacityBox.Text == "")
            {
                return false;
            }
            if (SeatsLeftBox.Text == "")
            {
                return false;
            }
            if (NumOfMeetingsBox.Text == "")
            {
                return false;
            }
            return true;

        }

        private bool IsAvailableDate()
        {
            foreach (Workshop w in Program.Workshops)
            {
                if ((DateTime.Compare(w.Get_startDate().Date, StartDatePicker.Value.Date) == 0) & w.Get_Activity() != Convert.ToInt32(IDBox.Text))
                {
                    return false;
                }
            }

            foreach (Lecture l in Program.Lectures)
            {
                if (DateTime.Compare(l.Get_startDate().Date, StartDatePicker.Value.Date) == 0)
                {
                    return false;
                }
            }

            foreach (CoachingMeeting c in Program.CoachingMeetings)
            {
                if (DateTime.Compare(c.Get_meetingDate().Date, StartDatePicker.Value.Date) == 0)
                {
                    return false;
                }
            }
            return true;

        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CheckList())
            {
                int ActivityID = Convert.ToInt32(IDBox.Text);
                string Name = NameBox.Text;
                string Description = DescriptionBox.Text;
                DateTime StartDate = StartDatePicker.Value + TimePicker.Value.TimeOfDay;
                int NumOfMeeting = Convert.ToInt32(NumOfMeetingsBox.Text);
                string Repetivity = RepetivityBox.Text + RepetivityBox2.Text;
                double Price = Convert.ToDouble(PriceBox.Text);
                int Capacity = Convert.ToInt32(CapacityBox.Text);
                int SeatsLeft = Convert.ToInt32(SeatsLeftBox.Text);
                string Location = LocationBox.Text;
                string Email = EmailBox.Text;

                Workshop ws = new Workshop(NumOfMeeting, Repetivity, StartDate, ActivityID, Email, Name, Description, Price, StartDate, Capacity, Location, SeatsLeft);
                ws.update_workshop();
                Program.init_workshops();
                closeForm();
            }
        }

        private void closeForm()
        {
            CRUD_Workshops c = new CRUD_Workshops();
            c.Show();
            this.Close();
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            closeForm();
        }

        private void UpdateWorkshop_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
