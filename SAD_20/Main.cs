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
    public partial class Main : Form
    {

        private DateTime dt = DateTime.Now;
        
        public Main()
        {
            InitializeComponent();

        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Confirm_BTN_Click(object sender, EventArgs e)
        {
            CheckInput();

        }

        private void CheckInput()
        {

           if ((string.IsNullOrEmpty(EmailTextbox.Text.Trim())) || (string.IsNullOrEmpty(PasswordTextbox.Text.Trim())))
           MessageBox.Show("Invalid Email or Password");
           else
           CheckUser(EmailTextbox.Text, PasswordTextbox.Text);
        }

        private void CheckUser(string Email, string Password)
        {
            Client cl = Program.seekClient(Email);
            CEO ceo = Program.seekCEO(Email);
            if (cl != null)
            {
                if (cl.get_password().Equals(Password))
                {
                    Program.user = cl;
                    ClientsMain CM = new ClientsMain();
                    CM.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid Password");
            }
            else if (ceo != null)
            {
                if (Password.Equals("RonnieIsTheKing"))
                {
                    CEOMain CeoM = new CEOMain();
                    CeoM.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid Password");
            }
            else
                MessageBox.Show("Invalid Email or Password");

        }

        private void VisibleBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.PasswordChar == '*')
            {
                VisibleBtn.BackColor = Color.Red;
                PasswordTextbox.PasswordChar = '\0';
            }
            else
            {
                VisibleBtn.BackColor = Color.ForestGreen;
                PasswordTextbox.PasswordChar = '*';
            }
        }

        private bool CheckActivityDone(int activityID, Lecture l)
        {
            if (Program.seekLecture(activityID) != null)
            {
                if (DateTime.Compare(l.Get_startDate(), dt) > 0)
                {
                    return true;
                }
            }
            /*else if(Program.seekWorkshop(activityID) != null)
            {
                Workshop w = Program.seekWorkshop(activityID);
                
                if (DateTime.Compare(w.Get_startDate(), dt) > 0)
                {
                    return true;
                }
            }*/
            return false;
        }

        /* private void EmailTimer_Tick(object sender, EventArgs e)
         {
             foreach(Booking b in Program.Bookings)
             {
                 Lecture l = Program.seekLecture(b.get_activityID());
                 Client c = Program.seekClient(b.get_email_client());
                 if (CheckActivityDone(b.get_activityID(), l))
                 {
                     Program.SendMail(b.get_email_client(), "ceodunetz@gmail.com", "Ronnie Dunetz", l.Get_name(), CreateBodyForReminder(c, l), "aB123456!");
                 }
             }
         }

         public string CreateBodyForReminder(Client c, Lecture l)
         {
             StringBuilder sb = new StringBuilder();
             sb.AppendLine("Hello " + c.get_name() + ",");
             sb.AppendLine("Please Remind to send Feedback About "+ l.Get_name());
             sb.AppendLine(" ");
             sb.AppendLine("Thank you and see you soon!");
             string body = sb.ToString();
             return body;
         }
     }*/
    }
}
