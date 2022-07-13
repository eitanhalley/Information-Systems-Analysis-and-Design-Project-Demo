using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class UserControlDaysCEO : UserControl
    {
        public static String static_day;
        public static int sched_static_day;
        private bool Apointments;
        private bool ApointmentsCoach;
        public UserControlDaysCEO()
        {
            InitializeComponent();
        }

        private void UserControlDaysCEO_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbDays.Text = numday + "";
            sched_static_day = numday;
        }

        public void availableDays()
        {
            Apointments = false;
            ApointmentsCoach = false;
        }

        private void UserControlDaysCEO_DoubleClick(object sender, EventArgs e)
        {
            if (ApointmentsCoach == true)
            {
                static_day = lbDays.Text;
                foreach (CoachingMeeting cm in Program.CoachingMeetings)
                {
                    if ((cm.Get_meetingDate().Day == Convert.ToInt32(UserControlDaysCEO.static_day)) && (cm.Get_meetingDate().Month == BussinesSchedule.static_month))
                    {
                        ViewCoachingMeetings VCM = new ViewCoachingMeetings();
                        VCM.Show();
                        break;
                    }
                }
            }
            else if (Apointments == true)
            {
                static_day = lbDays.Text;
                CEODaySchedule CEODS = new CEODaySchedule();
                CEODS.Show();
            }
            else
            {
                MessageBox.Show("no schedule apointments today sir, enjoy your free time you need it.....");
            }
        }//close double click

        public void scheduleCEOWorkshops()
        {
            BusySchedule.Text = "Workshops";
            this.BackColor = Color.Azure;
            Apointments = true;
        }
        public void scheduleCEOLectures()
        {
            BusySchedule.Text = "Lectures";
            this.BackColor = Color.Cyan;
            Apointments = true;
        }
        public void scheduleCEOCoachingMeetings()
        {
            BusySchedule.Text = "Coaching Meetings";
            this.BackColor = Color.LightGoldenrodYellow;
            ApointmentsCoach = true;
        }
    }
}
