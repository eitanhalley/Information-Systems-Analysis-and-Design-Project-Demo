using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_20
{
    public partial class SchedualeCoachingMeeting : Form
    {
        int month, year;
        public static int static_month, static_year;
        public SchedualeCoachingMeeting()
        {
            InitializeComponent();
        }

        private void SchedualeCoachingMeeting_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            displaDays();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            static_month = month;
            static_year = year;
            //getting the first day of the month

            DateTime startofthemonth = new DateTime(year,month, 1);
            //get the count of days in a month
            int days = DateTime.DaysInMonth(year, month);
            //convert start of the month into integer

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;

            //first lets create a blank control
            for(int i=1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);
            }

            //creating usercontrol for days
            
                for (int i = 1; i <= days; i++)
                {
                    UserControlDays ucdays = new UserControlDays();
                    ucdays.availableDays();
                    ucdays.days(i);
                    DayContainer.Controls.Add(ucdays);
                   
                foreach (Lecture l in Program.Lectures)
                    {
                        if((l.Get_startDate().Day == i) && (l.Get_startDate().Month == month))
                            ucdays.unavailableDays();
                     }//foreach
                foreach (Workshop w in Program.Workshops)
                {
                    if ((w.Get_startDate().Day == i) && (w.Get_startDate().Month == month))
                        ucdays.unavailableDays();
                }
            }//innerfor   
        }

               private void BtnPrevious_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days in a month
            int days = DateTime.DaysInMonth(year, month);
            //convert start of the month into integer

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lets create a blank control
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);
            }

            //creating usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);

                foreach (Lecture l in Program.Lectures)
                {
                    if ((l.Get_startDate().Day == i) && (l.Get_startDate().Month == month))
                        ucdays.unavailableDays();
                }
                foreach (Workshop w in Program.Workshops)
                {
                    if ((w.Get_startDate().Day == i) && (w.Get_startDate().Month == month))
                        ucdays.unavailableDays();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int days = DateTime.DaysInMonth(year, month);
            ClientsMain CM = new ClientsMain();
            CM.Show();
            this.Close();

        }

        private void DayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sunday_Click(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear(); 
            month++;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days in a month
            int days = DateTime.DaysInMonth(year, month);
            
            //convert start of the month into integer

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first lets create a blank control
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);
            }

            //creating usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);

                foreach (Lecture l in Program.Lectures)
                {
                    if ((l.Get_startDate().Day == i) && (l.Get_startDate().Month == month))
                        ucdays.unavailableDays();
                    
                }
                foreach (Workshop w in Program.Workshops)
                {
                    if ((w.Get_startDate().Day == i) && (w.Get_startDate().Month == month))
                        ucdays.unavailableDays();
                }
                }
        }
    }
}
