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
    public partial class CEODaySchedule : Form
    {
        public CEODaySchedule()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRTN_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void CEODaySchedule_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            textBox4.Text = UserControlDaysCEO.static_day + "/" + BussinesSchedule.static_month + "/" + BussinesSchedule.static_year;

            foreach (Lecture l in Program.Lectures)
            {
                if ((l.Get_startDate().Day == Convert.ToInt32(UserControlDaysCEO.static_day)) && (l.Get_startDate().Month == BussinesSchedule.static_month))
                {
                    txtName.Text = l.Get_name();
                    txtStart.Text = l.Get_startDate().Hour.ToString() + ":" + l.Get_startDate().Minute.ToString() + l.Get_startDate().Minute.ToString();
                    txtDur.Text = l.Get_startDate().AddHours(l.Get_duration()).Hour.ToString() + ":" + l.Get_startDate().AddHours(l.Get_duration()).Minute.ToString() + l.Get_startDate().AddHours(l.Get_duration()).Minute.ToString();
                }

            }

            foreach (Workshop w in Program.Workshops)
            {
                if ((w.Get_startDate().Day == Convert.ToInt32(UserControlDaysCEO.static_day)) && (w.Get_startDate().Month == BussinesSchedule.static_month))
                {
                    txtName.Text = w.Get_name();
                    if (w.Get_startDate().Minute == 0)
                    {
                        txtStart.Text = w.Get_startDate().Hour.ToString() + ":" + w.Get_startDate().Minute.ToString() + w.Get_startDate().Minute.ToString();
                        txtDur.Text = w.Get_startDate().AddHours(3.0).Hour.ToString() + ":" + w.Get_startDate().Minute.ToString() + w.Get_startDate().Minute.ToString();
                    }
                    else
                    {
                        txtStart.Text = w.Get_startDate().Hour.ToString() + ":" + w.Get_startDate().Minute.ToString();
                        txtDur.Text = w.Get_startDate().AddHours(3.0).Hour.ToString() + ":" + w.Get_startDate().Minute.ToString();
                    }
                   
                }
            }
         }
               
    }
}
