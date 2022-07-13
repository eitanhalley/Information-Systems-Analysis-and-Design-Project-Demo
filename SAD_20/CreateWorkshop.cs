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
    public partial class CreateWorkshop : Form
    {
        public CreateWorkshop()
        {
            InitializeComponent();
        }
        //We need to prevent overlapping workshop meeting somehow
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

  /*      static Regex ValidNameRegex = CreateValidNameRegex();
        private static Regex CreateValidNameRegex()
        {
            string ValidNameRegex = @"[^a-zA-Z\s]";

            return new Regex(ValidNameRegex, RegexOptions.IgnoreCase);
        }
        internal static bool NameValid(string name)
        {
            bool isValid = ValidNameRegex.IsMatch(name);

            return isValid;
        }
*/
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            
            if (CheckList())
            {
                string Name = NameBox.Text;
                string Description = DescriptionBox.Text;
                DateTime StartDate = StartDatePicker.Value.Date + TimePicker.Value.TimeOfDay;
                int NumOfMeeting = Convert.ToInt32(NumOfMeetingsBox.Text);
                string Repetivity = RepetivityBox.Text + RepitivityBox2.Text;
                double Price = Convert.ToDouble(PriceBox.Text);
                int Capacity = Convert.ToInt32(CapacityBox.Text);
                string Location = LocationBox.Text;
                string Email = "CEO@post.bgu.ac.il";
                Random activityID = new Random();

                Workshop ws = new Workshop(NumOfMeeting, Repetivity, StartDate, activityID.Next(), Email, Name, Description, Price, StartDate, Capacity, Location, Capacity);
                ws.create_workshop();
                Program.init_workshops();
                closeForm();
            }
            

        }


        public bool CheckList()
        {

            if(!checkInserted())
            {
                MessageBox.Show("You must fill all details, please try again!");
                return false;
            }


            foreach (Workshop w in Program.Workshops)
            {

                if (w.Get_name() == NameBox.Text & w.Get_startDate() == StartDatePicker.Value)
                {
                    MessageBox.Show("Workshop is already exsits , please try again!");
                    return false;
                }

            }
            if (Convert.ToDouble(PriceBox.Text) < 0)
            {
                MessageBox.Show("Price Input InValid!");
                return false;
            }


            if (Convert.ToDouble(PriceBox.Text) < 0)
            {
                MessageBox.Show("Price is Unvaild , please try again !");
                return false;
            }


            if(!IsAvailableDate())
            {
                MessageBox.Show("Your Date is Unavailable , please try again !");
                return false;
            }


            if(Convert.ToInt32(CapacityBox.Text) <= 0)
            {
                MessageBox.Show("Capacity is Unvalid , please try again !");
                return false;
            }


            return true;
        }

        private bool checkInserted()
        {
            if(NameBox.Text == "")
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
            if(CapacityBox.Text == "")
            {
                return false;
            }
            if(NumOfMeetingsBox.Text == "")
            {
                return false;
            }
            return true;

        }

        private bool IsReasonableNOM()
        {

           if((TimePicker.Value - StartDatePicker.Value).TotalDays < Convert.ToInt32(NumOfMeetingsBox.Text))
            {
                return false;
            }
            return true;

        }

        private bool IsAvailableDate ()
        {
            foreach (Workshop w in Program.Workshops)
            {
                if ((DateTime.Compare(w.Get_startDate().Date, StartDatePicker.Value.Date) == 0))
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

        private void closeForm()
        {
            CRUD_Workshops c = new CRUD_Workshops();
            c.Show();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void CreateWorkshop_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }


}
