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
    public partial class UserControlDays : UserControl
    {
        public static String static_day;
        public static int sched_static_day;
        private bool unavailable;        
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbDays.Text = numday + "";
           sched_static_day = numday;
        }

        public void availableDays()
        {
            unavailable = false;
        }
        public void unavailableDays()
        {
            notAvailable.Text = "unavailable";
            this.BackColor = Color.Tomato;
            unavailable = true;
        }

        private void UserControlDays_DoubleClick(object sender, EventArgs e)
        {
            if (unavailable == true)
            {
                MessageBox.Show("this date is not available please choose another date");
            }

            else
            {
                static_day = lbDays.Text;
                dailyScheduale DS = new dailyScheduale();
                DS.Show();
            }
        }
    }//class user control days
}

