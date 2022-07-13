using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//חשוב שחף!!!

namespace SAD_20
{
    public class Feedback
    {
        private int feedbackID;
        private DateTime feedbackDate;
        private Rank rank;
        private string feedbackText;
        private string email_client;
        private int activityID;

        public Feedback(int id, DateTime date, Rank rank, string text, string email, int activityID)
        {
            this.feedbackID = id;
            this.feedbackDate = date;
            this.rank = rank;
            this.feedbackText = text;
            this.email_client = email;
            this.activityID = activityID;

        }

        //Getters
        public int get_feedbackID()
        {
            return feedbackID;
        }
        public DateTime get_feedbackDate()
        {
            return feedbackDate;
        }
        public Rank get_rank()
        {
            return rank;
        }
        public string get_feedbackText()
        {
            return feedbackText;
        }
        public string get_email_client()
        {
            return email_client;
        }
        public int get_activityID()
        {
            return activityID;
        }

        //Setters
        public void set_feedbackID(int id)
        {
            this.feedbackID=id;
        }
        public void set_feedbackDate(DateTime date)
        {
            this.feedbackDate=date;
        }
        public void set_rank(Rank rank)
        {
            this.rank=rank;
        }
        public void set_feedbackText(string text)
        {
            this.feedbackText=text;
        }
        public void set_email_client(string email)
        {
            this.email_client=email;
        }
        public void set_activityID(int id)
        {
            this.activityID=id;
        }
        public void create_feedback()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Feedback @FeedbackID, @FeedbackDate, @Rank, @FeedbackText, @Email_Client, @ActivityID";
            c.Parameters.AddWithValue("@FeedbackID", this.feedbackID);
            c.Parameters.AddWithValue("@FeedbackDate", this.feedbackDate);
            c.Parameters.AddWithValue("@Rank", this.rank);
            c.Parameters.AddWithValue("@FeedbackText", this.feedbackText);
            c.Parameters.AddWithValue("@Email_Client", this.email_client);
            c.Parameters.AddWithValue("@ActivityID", this.activityID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }//close create_feedback
       
    }//clos class feedback
}//close SAD_20
