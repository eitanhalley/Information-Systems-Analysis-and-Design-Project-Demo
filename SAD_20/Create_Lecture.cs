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
    public partial class Create_Lecture : Form
    {
        public Create_Lecture()
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

        private void CreateLecture_Click(object sender, EventArgs e)
        {
            if (CheckList())


            {
                Double duration = Convert.ToDouble(txtDuration.Text);
                String Name = txtName.Text;
                String descripton = txtDescription.Text;
                Double price = Convert.ToDouble(txtPrice.Text);
                DateTime startDate = DatePicker.Value.Date + TimePicker.Value.TimeOfDay;
                int capacity = Convert.ToInt32(txtCapacity.Text);
                String location = txtLocation.Text;
                Random ID = new Random();

               LectureType L = (LectureType)Enum.Parse(typeof(LectureType), comboBoxType.SelectedItem.ToString());
                Lecture w = new Lecture(duration, L ,ID.Next() ,"CEO@post.bgu.ac.il" ,Name ,descripton ,price,startDate ,capacity, location, capacity);
                w.create_lecture();
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
            if (!checkInserted())// ALL
            {
                MessageBox.Show("You must fill all details , please try again!");
                return false;
            }

            if (Convert.ToInt32(txtPrice.Text) < 0)// Price>0
            {
                MessageBox.Show("Price Must Be Greater then 0!");
                return false;
            }

            if (Convert.ToDouble(txtPrice.Text) < 0)// Price>0
            {
                MessageBox.Show("Price Must Be Greater then 0!");
                return false;
            }

            if (Convert.ToInt32(txtCapacity.Text) < 0)// Capacity>0
            {
                MessageBox.Show("Capacity Must Be Positive , please try again !");
                return false;
            }

            if (!IsAvailableDate())// HERE
            {
                MessageBox.Show("Your Date is Unavailable , please try again !");
                return false;
            }

            if (existingLecture())
            {
                MessageBox.Show("That's an existing lecture , please try again !");
                return false;
            }

            return true;
                
        }

        private bool checkInserted()
        {
            if (txtDuration.Text == "")
            {
                return false;
            }
            if (comboBoxType.Text == "")
            {
                return false;
            }
            if (txtName.Text == "")
            {
                return false;
            }

            if (txtDescription.Text == "")
            {
                return false;
            }
            if (txtPrice.Text == "")
            {
                return false;
            }
            if (DatePicker.Value.Equals(""))
            {
                return false;
            }
            if (txtCapacity.Text == "")
            {
                return false;
            }
            if (txtLocation.Text == "")
            {
                return false;
            }

            return true;

        }

        private bool existingLecture()
        {
            foreach (Lecture l in Program.Lectures)
            {
                if (l.Get_name() == txtName.Text)
                {
                    if (l.Get_startDate().Date == DatePicker.Value.Date)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool IsAvailableDate()
        {//Need to fix the Date Checking
            foreach (Workshop w in Program.Workshops)
            {
                if ((DateTime.Compare(w.Get_startDate().Date, DatePicker.Value.Date) == 0))
                {
                    return false;
                }
            }

            foreach (Lecture l in Program.Lectures)
            {
                if (DateTime.Compare(l.Get_startDate().Date, DatePicker.Value.Date) == 0)
                {
                    return false;
                }

            }

            foreach (CoachingMeeting c in Program.CoachingMeetings)
            {
                if (DateTime.Compare(c.Get_meetingDate().Date, DatePicker.Value.Date) == 0)
                {
                    return false;
                }
            }
            return true;


        }

        private void CloseCreateLecture_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void Create_Lecture_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
