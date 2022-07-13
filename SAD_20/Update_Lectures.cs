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
    public partial class Update_Lectures : Form
    {
        public Update_Lectures()
        {
            InitializeComponent();
            comboBoxType.DataSource = Enum.GetValues(typeof(LectureType));
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




        private void txtID_Update_Lectures_TextChanged(object sender, EventArgs e)
        {

        }

        private void Find_Lecture_BTN_Click(object sender, EventArgs e)// Find lecture button
        {
            if (txtID_Update_Lectures.Text == "")
            {
                MessageBox.Show("You must fill ID , please try again!");
            }
            if (!Regex.IsMatch(txtID_Update_Lectures.Text, @"^\d+$"))
            {
                MessageBox.Show("ID must contain only numbers, please try again!");
            }
            else if (Program.seekLecture(Convert.ToInt32(txtID_Update_Lectures.Text)) != null)
            {
                Lecture L = Program.seekLecture(Convert.ToInt32(txtID_Update_Lectures.Text));
                txtDuration_Update_Lectures.Text = L.Get_duration().ToString();
                comboBoxType.Text = L.Get_lectureType().ToString();
                txtEmail_Update_Lectures.Text = L.Get_email().ToString();
                txtName_Update_Lectures.Text = L.Get_name().ToString();
                txtDescription_Update_Lectures.Text = L.Get_descripton().ToString();
                txtPrice_Update_Lectures.Text = L.Get_price().ToString();
                Picker_Strat_Date.Value = L.Get_startDate();
                TimePicker.Value = L.Get_startDate();
                txtCapacity_Update_Lectures.Text = L.Get_capacity().ToString();
                txtLocation_Update_Lectures.Text = L.Get_location().ToString();
                txtSeats_Update_Lectures.Text = L.Get_seatsLeft().ToString();
                  
            }
            else
                MessageBox.Show("Lecture Not Found , please try again!");
        }

        private void Update_Lecture_BTN_Click(object sender, EventArgs e)
        {
            if (CheckList())
            {
                Lecture L = Program.seekLecture(Convert.ToInt32(txtID_Update_Lectures.Text));

                L.Set_duration(Convert.ToDouble(txtDuration_Update_Lectures.Text));
                L.Set_LectureType((LectureType)Enum.Parse(typeof(LectureType),comboBoxType.SelectedItem.ToString()));
                L.Set_email(txtEmail_Update_Lectures.Text);
                L.Set_name(txtName_Update_Lectures.Text);
                L.Set_description(txtDescription_Update_Lectures.Text);
                L.Set_price(Convert.ToDouble(txtPrice_Update_Lectures.Text));
                DateTime date = Picker_Strat_Date.Value.Date + TimePicker.Value.TimeOfDay;
                L.Set_startDate(date);
                L.Set_capacity(Convert.ToInt32(txtCapacity_Update_Lectures.Text));
                L.Set_location(txtLocation_Update_Lectures.Text);
                L.Set_seatsLeft(Convert.ToInt32(txtSeats_Update_Lectures.Text));

                L.update_lecture();
                Program.init_lectures();
               
                closeForm();
            }
        }

        private void closeForm()// close this form after Update
        {
            CRUD_Lectures c = new CRUD_Lectures();
            c.Show();
            this.Close();
        }

        public bool CheckList()
        {

            if (Convert.ToInt32(txtID_Update_Lectures.Text) < 0)// ID>0
            {
                MessageBox.Show("ID Must Be Positive, please try again!");
                return false;
            }

            if (!checkInserted())// ALL
            {
                MessageBox.Show("You must fill all Boxes , please try again!");
                return false;
            }

            if (Convert.ToDouble(txtPrice_Update_Lectures.Text) < 0)// Price>0
            {
                MessageBox.Show("Price Must Be Greater then 0!");
                return false;
            }

            if (!EmailIsValid(txtEmail_Update_Lectures.Text))// Email 
            {
                MessageBox.Show("Your Email Input is no vaild , please try again !");
                return false;
            }

            if(Convert.ToInt32(txtCapacity_Update_Lectures.Text)<0 )// Capacity>0
            {
                MessageBox.Show("Capacity Must Be Positive , please try again !");
                return false;
            }


            if (!IsAvailableDate())// HERE
            {
                MessageBox.Show("Your Date is Unavailable , please try again !");
                return false;
            }


            if (Convert.ToInt32(txtSeats_Update_Lectures.Text) <= 0)
            {
                MessageBox.Show("Seats Left is Unvalid , please try again !");
                return false;
            }

            return true;
        }

        private bool checkInserted()
        {
            if (txtID_Update_Lectures.Text == "")
            {
                return false;
            }
            if (txtDuration_Update_Lectures.Text == "")
            {
                return false;
            }
            if (comboBoxType.Text == "")
            {
                return false;
            }
            if (txtEmail_Update_Lectures.Text == "")
            {
                return false;
            }
            if (txtName_Update_Lectures.Text == "")
            {
                return false;
            }

            if (txtDescription_Update_Lectures.Text == "")
            {
                return false;
            }
            if (txtPrice_Update_Lectures.Text == "")
            {
                return false;
            }
            if (Picker_Strat_Date.Value.Equals(""))
            {
                return false;
            }
            if (txtCapacity_Update_Lectures.Text == "")
            {
                return false;
            }
            if (txtLocation_Update_Lectures.Text == "")
            {
                return false;
            }
            if (txtSeats_Update_Lectures.Text == "")
            {
                return false;
            }

            return true;

        }

        private bool IsAvailableDate()
        {//Need to fix the Date Checking
            Lecture L = Program.seekLecture(Convert.ToInt32(txtID_Update_Lectures.Text));

            foreach (Workshop w in Program.Workshops)
            {
                if (w.Get_Activity() != L.Get_activityID())
                {
                    if ((DateTime.Compare(w.Get_startDate(), Picker_Strat_Date.Value) == 0))
                    {
                        return false;
                    }
                    else if ((DateTime.Compare(w.Get_EndDate(), Picker_Strat_Date.Value) == 0))
                    {
                        return false;
                    }
                }
            }
            
                foreach (Lecture l in Program.Lectures)
                {
                    if (l.Get_activityID() != L.Get_activityID())
                    {
                        if (DateTime.Compare(l.Get_startDate(), Picker_Strat_Date.Value) == 0)
                        {
                           return false;
                        }
                        else if (DateTime.Compare(l.Get_startDate(), Picker_Strat_Date.Value) == 0)
                        {
                        return false;
                        }
                    }
                }
            

            foreach (CoachingMeeting c in Program.CoachingMeetings)
            {
                if (DateTime.Compare(c.Get_meetingDate(), Picker_Strat_Date.Value) == 0)
                {
                    return false;
                }
                else if (DateTime.Compare(c.Get_meetingDate(), Picker_Strat_Date.Value) == 0)
                {
                    return false;
                }
            }
            return true;


        }

        private void Cancel_Lecture_BTN_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void Update_Lectures_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
