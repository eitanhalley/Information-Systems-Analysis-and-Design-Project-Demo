using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SAD_20
{
    public partial class BussinesSchedule : Form
    {

        int month, year;
        public static int static_month, static_year;
        public BussinesSchedule()
        {
            InitializeComponent();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            DayContainer2.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            String monthname1 = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATECEO.Text = monthname1 + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days in a month
            int days = DateTime.DaysInMonth(year, month);
            //convert start of the month into integer

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lets create a blank control
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer2.Controls.Add(ucblank);
            }

            //creating usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDaysCEO ucdaysCEO = new UserControlDaysCEO();
                ucdaysCEO.days(i);
                ucdaysCEO.availableDays();
                DayContainer2.Controls.Add(ucdaysCEO);
                
                foreach (Lecture l in Program.Lectures)
                {
                    if ((l.Get_startDate().Day == i) && (l.Get_startDate().Month == month))
                        ucdaysCEO.scheduleCEOLectures();
                }
                foreach (Workshop w in Program.Workshops)
                {
                    if ((w.Get_startDate().Day == i) && (w.Get_startDate().Month == month))
                        ucdaysCEO.scheduleCEOWorkshops();
                }
                foreach (CoachingMeeting M in Program.CoachingMeetings)
                {
                    if ((M.Get_meetingDate().Day == i) && (M.Get_meetingDate().Month == month))
                        ucdaysCEO.scheduleCEOCoachingMeetings();
                }
            }
        }

        private void btn_rtn_Click(object sender, EventArgs e)
        {
            CEOMain CM = new CEOMain();
            CM.Show();
            this.Close();
        }

        private void BussinesSchedule_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            displaDays();
        }

        private void btn_nxt_Click(object sender, EventArgs e)
        {
            DayContainer2.Controls.Clear();
            month++;
            static_month = month;
            static_year = year;
            String monthname1 = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATECEO.Text = monthname1 + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days in a month
            int days = DateTime.DaysInMonth(year, month);

            //convert start of the month into integer

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lets create a blank control
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer2.Controls.Add(ucblank);
            }

            //creating usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDaysCEO ucdaysCEO = new UserControlDaysCEO();
                ucdaysCEO.days(i);
                DayContainer2.Controls.Add(ucdaysCEO);

                foreach (Lecture l in Program.Lectures)
                {
                    if ((l.Get_startDate().Day == i) && (l.Get_startDate().Month == month))
                        ucdaysCEO.scheduleCEOLectures();

                }
                foreach (Workshop w in Program.Workshops)
                {
                    if ((w.Get_startDate().Day == i) && (w.Get_startDate().Month == month))
                        ucdaysCEO.scheduleCEOWorkshops();
                }
                foreach (CoachingMeeting M in Program.CoachingMeetings)
                {
                    if ((M.Get_meetingDate().Day == i) && (M.Get_meetingDate().Month == month))
                        ucdaysCEO.scheduleCEOCoachingMeetings();
                }
            }
        }


        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname1 = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATECEO.Text = monthname1 + " " + year;

            static_month = month;
            static_year = year;
            //getting the first day of the month

            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days in a month
            int days = DateTime.DaysInMonth(year, month);
            //convert start of the month into integer

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lets create a blank control
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank1 = new UserControlBlank();
                DayContainer2.Controls.Add(ucblank1);
            }

            //creating usercontrol for days

            for (int i = 1; i <= days; i++)
            {
                UserControlDaysCEO ucdaysCEO = new UserControlDaysCEO();
                ucdaysCEO.days(i);
                DayContainer2.Controls.Add(ucdaysCEO);

                foreach (Lecture l in Program.Lectures)
                {
                    if ((l.Get_startDate().Day == i) && (l.Get_startDate().Month == month))
                        ucdaysCEO.scheduleCEOLectures();
                }//foreach
                foreach (Workshop w in Program.Workshops)
                {
                    if ((w.Get_startDate().Day == i) && (w.Get_startDate().Month == month))
                        ucdaysCEO.scheduleCEOWorkshops();
                }
                foreach (CoachingMeeting M in Program.CoachingMeetings)
                {
                    if ((M.Get_meetingDate().Day == i) && (M.Get_meetingDate().Month == month))
                        ucdaysCEO.scheduleCEOCoachingMeetings();
                }
            }//innerfor   
        }
    }
}
