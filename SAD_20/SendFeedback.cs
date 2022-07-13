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
    public partial class SendFeedback : Form
    {
        DateTime today = DateTime.Now;

        public SendFeedback()
        {
            InitializeComponent();
            RankBox.DataSource = Enum.GetValues(typeof(Rank));
        }

        private void SendFeedback_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backgroun_nice;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            dataGridView1.Rows.Clear();
            foreach (Booking b in Program.Bookings)
            {
                if (!b.IsFeedbackedAlready() && Program.user.get_email().Equals(b.get_email_client()))
                {
                    Lecture Activity = Program.seekLecture(b.get_activityID());
                    if (Activity != null && (DateTime.Compare(today, Activity.Get_startDate()) > 0))
                    {
                        dataGridView1.Rows.Add(b.get_bookingID(), b.get_price(), b.get_activityID(), Activity.Get_name());
                    }
                    Workshop w = Program.seekWorkshop(b.get_activityID());
                    if (w != null && DateTime.Compare(today, w.Get_startDate()) > 0)
                    {
                        dataGridView1.Rows.Add(b.get_bookingID(), b.get_price(), b.get_activityID(), Program.seekWorkshop(b.get_activityID()).Get_name());
                    }
                }

            }


        }

        private void CreateFeedbackBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    CreateFeedback((int)dataGridView1.SelectedCells[2].Value);
                }
                catch
                {
                    MessageBox.Show("You don't have any feedback to fill");
                }
            }
        }

        private bool isValid()
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 0)
            {
                MessageBox.Show("Please select an option");
                return false;
            }
            else if (selectedRowCount > 1)
            {
                MessageBox.Show("Please select single option");
                return false;
            }
            else if (RankBox.Text == "")
            {
                MessageBox.Show("Please fill Rank");
                return false;
            }
            return true;
        }

        private void CreateFeedback(int id)
        {
            int activityid = id;
            string client_email = Program.user.get_email();
            DateTime feedbackDate = DateTime.Now;
            Rank rank = (Rank)Enum.Parse(typeof(Rank), RankBox.Text);
            string feedbackText = FreeTextBox.Text;
            var rand = new Random();
            int feedbackID = rand.Next(1, 999999);
            while (Program.seekFeedback(feedbackID) != null)
            {
                feedbackID = rand.Next(1, 999999);
            }
            Feedback f = new Feedback(feedbackID, feedbackDate, rank, feedbackText, client_email, activityid);
            f.create_feedback();
            Program.Feedbacks.Add(f);
            MessageBox.Show("Thank you for the feedback!");
            SendFeedback sf = new SendFeedback();
            sf.Show();
            this.Close();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            ClientsMain cm = new ClientsMain();
            cm.Show();
            this.Close();
        }
    }
}
