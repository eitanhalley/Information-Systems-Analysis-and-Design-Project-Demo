using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace SAD_20
{
    public partial class ClientsMain : Form
    {
        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "SAD20";
        DateTime today = DateTime.Now;
        public ClientsMain()
        {
            InitializeComponent();
            
        }

        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        private void SendEmail(string email_client)
        {
            UserCredential credential;
            //read your credentials file
            using (FileStream stream = new FileStream(Application.StartupPath + @"/credentials.json", FileMode.Open, FileAccess.Read))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(path, true)).Result;
            }

            string message = $"To: {email_client}\r\nSubject: {"Please send feedback"}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h1>{"Hey, please remind to send feedback about your actvities. "}</h1>";
            //call your gmail service
            var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
            var msg = new Google.Apis.Gmail.v1.Data.Message();
            msg.Raw = Base64UrlEncode(message.ToString());
            service.Users.Messages.Send(msg, "me").Execute();
            MessageBox.Show("Your email has been successfully sent !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ClientsMain_Load(object sender, EventArgs e)
        {
            setBackground();
            string[] fullname = Program.user.get_name().Split(' ');
            label.Text = "Hi, " + fullname[0] + " :)";


            if (CheckIfNeedToFeedback())
            {
                SendReminder();
            }


        }

        private bool CheckIfNeedToFeedback()
        {
            foreach (Booking b in Program.Bookings)
            {
                if ((!b.IsFeedbackedAlready()) && (Program.user.get_email().Equals(b.get_email_client())))
                {
                    Lecture l = Program.seekLecture(b.get_activityID());
                    if (l != null && (DateTime.Compare(today, l.Get_startDate()) > 0))
                    {
                        return true;
                    }
                    Workshop w = Program.seekWorkshop(b.get_activityID());
                    if (w != null && DateTime.Compare(today, w.Get_startDate()) > 0)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        private void SendReminder()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Do you have feedback to fill");
            sb.Append(Environment.NewLine);
            sb.Append("Want to fill it now?");
            sb.Append(Environment.NewLine);
            if (!Program.isSend)
            {
                var result = MessageBox.Show(sb.ToString(), "Confirm booking",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Program.isSend = true;
                    SendFeedback sf = new SendFeedback();
                    sf.Show();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    Program.isSend = true;
                    SendEmail(Program.user.get_email());
                }
            }
        }

        private void setBackground()
        {
            if (Program.user.get_email() == "gildu@post.bgu.ac.il")
            {
                this.BackgroundImage = Properties.Resources.Background_gil;
            }
            if (Program.user.get_email() == "poursh@post.bgu.ac.il")
            {
                this.BackgroundImage = Properties.Resources.Background_shahaf;
            }
            if (Program.user.get_email() == "omef@post.bgu.ac.il")
            {
                this.BackgroundImage = Properties.Resources.Background_omer;
            }
            if (Program.user.get_email() == "eithanhal@post.bgu.ac.il")
            {
                this.BackgroundImage = Properties.Resources.Background_eithan;
            }
            if (Program.user.get_email() == "cohran@post.bgu.ac.il")
            {
                this.BackgroundImage = Properties.Resources.Background_Cochran;
            }
            if (Program.user.get_email() == "mayre@post.bgu.ac.il")
            {
                this.BackgroundImage = Properties.Resources.Background_may;
            }
            if (Program.user.get_email() == "itzikgu@post.bgu.ac.il")
            {
                this.BackgroundImage = Properties.Resources.Background_itzik;
            }
            /*else
            {
                this.BackgroundImage = Properties.Resources.Backgroun_nice;
            }*/
        }

        private void FeedbacksBtn_Click(object sender, EventArgs e)
        {
            SendFeedback sf = new SendFeedback();
            sf.Show();
            this.Close();
        }

        private void AboutCEOBtn_Click(object sender, EventArgs e)
        {
            AboutCEO ac = new AboutCEO();
            ac.Show();
            this.Close();
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            SchedualeCoachingMeeting scm = new SchedualeCoachingMeeting();
            scm.Show();
            this.Close();
        }

        private void WorkshopsBTN_Click(object sender, EventArgs e)
        {
            ViewWorkshops_Client vw = new ViewWorkshops_Client();
            this.Close();
            vw.Show();
        }

        private void LecturesBtn_Click(object sender, EventArgs e)
        {
            ViewLectures_Client v = new ViewLectures_Client();
            this.Close();
            v.Show();
        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            Main c = new Main();
            this.Close();
            c.Show();
        }
    }
}
