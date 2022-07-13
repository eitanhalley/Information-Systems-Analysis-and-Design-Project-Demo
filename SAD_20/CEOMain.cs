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
    public partial class CEOMain : Form
    {
        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "SAD20";

        public CEOMain()
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

            string message = $"To: {email_client}\r\nSubject: {"Discount for Ronnie's Activities"}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h1>{"Hey, We didn't see you for a while, so you get discount of 50% on any activities. "}</h1>";
            //call your gmail service
            var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
            var msg = new Google.Apis.Gmail.v1.Data.Message();
            msg.Raw = Base64UrlEncode(message.ToString());
            service.Users.Messages.Send(msg, "me").Execute();
            MessageBox.Show("Your email has been successfully sent !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void WorkshopsBtn_Click(object sender, EventArgs e)
        {
            CRUD_Workshops c = new CRUD_Workshops();
            c.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }

        private void ClientsBtn_Click(object sender, EventArgs e)
        {
            Clients_CRUD c = new Clients_CRUD();
            c.Show();
            this.Close();
        }

        private void LecturesBtn_Click(object sender, EventArgs e)
        {
            CRUD_Lectures cl = new CRUD_Lectures();
            cl.Show();
            this.Close();
        }


        private void SeekPotentialClient()
        {

            foreach (Client c in Program.Clients)
            {
                TimeSpan ts = DateTime.Now - c.get_lastActivityDate();
                int days = ts.Days;
                if (((c.get_numOfCoachinigMeetings() == 0) || (c.get_numOfLectures() == 0 && c.get_numOfWorkshops() == 0) || (days > 365)) && c.get_discount() != 0.5)
                {
                    c.set_discount(0.5);
                    c.update_client();
                    SendEmail(c.get_email());
                }
            }


        }

        private void FPCBtn_Click(object sender, EventArgs e)
        {
            SeekPotentialClient();
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            BussinesSchedule BS = new BussinesSchedule();
            BS.Show();
            this.Close();
        }
    }
}
