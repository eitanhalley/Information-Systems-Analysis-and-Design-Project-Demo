using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SAD_20
{
    public partial class dailyScheduale : Form
    {
        int occupied;
        public dailyScheduale()
        {
            InitializeComponent();
        }
        private void dailyScheduale_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            txtDate.Text = UserControlDays.static_day + "/" + SchedualeCoachingMeeting.static_month + "/" + SchedualeCoachingMeeting.static_year;
            
            
            mark_Occupied(btn9AM,9);
            mark_Occupied( btn10AM,10);
            mark_Occupied( btn11AM,11);
            mark_Occupied(btn12PM, 12);
            mark_Occupied( btn2PM,14);
            mark_Occupied(btn3PM,15);
            mark_Occupied( btn4PM,16);
            mark_Occupied(btn5PM, 17);
           




        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void mark_Occupied(Button btn , int i)
        {
            DateTime schedDate = new DateTime(SchedualeCoachingMeeting.static_year, SchedualeCoachingMeeting.static_month, Convert.ToInt32(UserControlDays.static_day), i, 0, 0);
            foreach (CoachingMeeting CM in Program.CoachingMeetings)
            {
                occupied = DateTime.Compare(CM.Get_meetingDate(), schedDate);
                if (occupied == 0)
                {
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                }

            }
        }

        private void btn9AM_Click(object sender, EventArgs e)
        {
            DateTime schedDate = new DateTime(SchedualeCoachingMeeting.static_year, SchedualeCoachingMeeting.static_month, Convert.ToInt32(UserControlDays.static_day), 9, 0, 0);
            addingCoachMeeting(schedDate);
            mark_Occupied(btn9AM, 9);
        }

        private void btn10AM_Click(object sender, EventArgs e)
        {
                DateTime schedDate = new DateTime(SchedualeCoachingMeeting.static_year, SchedualeCoachingMeeting.static_month, Convert.ToInt32(UserControlDays.static_day), 10, 0, 0);
                addingCoachMeeting(schedDate);
                mark_Occupied(btn10AM, 10);
        }

        private void btn11AM_Click(object sender, EventArgs e)
        {
            DateTime schedDate = new DateTime(SchedualeCoachingMeeting.static_year, SchedualeCoachingMeeting.static_month, Convert.ToInt32(UserControlDays.static_day), 11, 0, 0);
            addingCoachMeeting(schedDate);
            mark_Occupied(btn11AM,11);
        }

        private void btn12PM_Click(object sender, EventArgs e)
        {
            DateTime schedDate = new DateTime(SchedualeCoachingMeeting.static_year, SchedualeCoachingMeeting.static_month, Convert.ToInt32(UserControlDays.static_day), 12, 0, 0);
            addingCoachMeeting(schedDate);
            mark_Occupied(btn12PM,12);
        }

        private void btn2PM_Click(object sender, EventArgs e)
        {
            DateTime schedDate = new DateTime(SchedualeCoachingMeeting.static_year, SchedualeCoachingMeeting.static_month, Convert.ToInt32(UserControlDays.static_day), 14, 0, 0);
            addingCoachMeeting(schedDate);
            mark_Occupied(btn2PM, 14);
        }

        private void btn3PM_Click(object sender, EventArgs e)
        {
            DateTime schedDate = new DateTime(SchedualeCoachingMeeting.static_year, SchedualeCoachingMeeting.static_month, Convert.ToInt32(UserControlDays.static_day), 15, 0, 0);
            addingCoachMeeting(schedDate);
            mark_Occupied(btn3PM, 15);
        }

        private void btn4PM_Click(object sender, EventArgs e)
        {
            DateTime schedDate = new DateTime(SchedualeCoachingMeeting.static_year, SchedualeCoachingMeeting.static_month, Convert.ToInt32(UserControlDays.static_day), 16, 0, 0);
            addingCoachMeeting(schedDate);
            mark_Occupied(btn4PM,16);
        }

        private void btn5PM_Click(object sender, EventArgs e)
        {
            DateTime schedDate = new DateTime(SchedualeCoachingMeeting.static_year, SchedualeCoachingMeeting.static_month, Convert.ToInt32(UserControlDays.static_day), 17, 0, 0);
            addingCoachMeeting(schedDate);
            mark_Occupied(btn5PM,17);
            dailyScheduale DS = new dailyScheduale();
            DS.Show();
            this.Close();
        }

        private void addingCoachMeeting( DateTime schedDate)
        {
            Random rnd = new Random();
            DateTime MeetingDate = schedDate;
            DateTime BookingDate = DateTime.Now;
            Double price = 400 * (1 - Program.user.get_discount());
            int meetingNum = Program.user.get_numOfCoachinigMeetings();
            String ClEmail = Program.user.get_email();
            String CEOEmail = "CEO@post.bgu.ac.il";
            CoachingMeeting newCM = new CoachingMeeting(rnd.Next(), BookingDate, MeetingDate, price, meetingNum, ClEmail, CEOEmail);
            newCM.create_coachingMeeting();
            Program.user.set_numOfCoachinigMeetings(meetingNum + 1);
            Program.user.update_client();
            MessageBox.Show("Addad ChoachMeeting to schedule succesfully");
            Program.init_CoachingMeetings();
        }
    }
}
