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
    public partial class ViewCoachingMeetings : Form
    {
        int IsOccupied;
        public ViewCoachingMeetings()
        {
            InitializeComponent();
        }

        private void ViewCoachingMeetings_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            txtCoachDate.Text = UserControlDaysCEO.static_day + "/" + BussinesSchedule.static_month + "/" + BussinesSchedule.static_year;


            mark_Occupied(btn9AM, 9);
            mark_Occupied(btn10AM, 10);
            mark_Occupied(btn11AM, 11);
            mark_Occupied(btn12PM, 12);
            mark_Occupied(btn14PM, 14);
            mark_Occupied(btn15PM, 15);
            mark_Occupied(btn16PM, 16);
            mark_Occupied(btn17PM, 17);
        }

        private void mark_Occupied(Button btn, int i)
        {
            DateTime schedDate = new DateTime(BussinesSchedule.static_year, BussinesSchedule.static_month, Convert.ToInt32(UserControlDaysCEO.static_day), i, 0, 0);
            foreach (CoachingMeeting CM in Program.CoachingMeetings)
            {
                IsOccupied = DateTime.Compare(CM.Get_meetingDate(), schedDate);
                if (IsOccupied == 0)
                {
                    btn.BackColor = Color.PaleGoldenrod;
                    btn.Enabled = false;
                    foreach(CoachingMeeting cm in Program.CoachingMeetings)
                    {
                        if((cm.Get_meetingDate().Day == Convert.ToInt32(UserControlDaysCEO.static_day)) && (cm.Get_meetingDate().Month == BussinesSchedule.static_month)&& cm.Get_meetingDate().Hour == i)
                        {
                            btn.Text = Program.seekClientName(cm.Get_emailClient()) + "  -  " + cm.Get_meetingDate().Hour + ":" + cm.Get_meetingDate().Minute + cm.Get_meetingDate().Minute;
                        }
                    }
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
