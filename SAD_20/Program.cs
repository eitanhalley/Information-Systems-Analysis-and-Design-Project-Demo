using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
//using System.Net;

namespace SAD_20
{
    static class Program
    {
        public static System.Collections.Generic.List<Client> Clients;
        public static System.Collections.Generic.List<Workshop> Workshops;
        public static System.Collections.Generic.List<Lecture> Lectures;
        public static System.Collections.Generic.List<CoachingMeeting> CoachingMeetings;
        public static System.Collections.Generic.List<Booking> Bookings;
        public static System.Collections.Generic.List<Feedback> Feedbacks;
        public static System.Collections.Generic.List<Equipment> Equipments;
        public static System.Collections.Generic.List<CEO> CEOS;
        public static Client user = null;
        public static bool isSend = false;
        [STAThread]



        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
        public static Client seekClient(string email)
        {
            foreach (Client c in Clients)
            {
                if (c.get_email() == email)
                    return c;
            }
            return null;
        }
        public static String seekClientName(string email)
        {
            foreach (Client c in Program.Clients)
            {
                if (c.get_email() == email)
                    return c.get_name();
            }
            return null;
        }
        public static CEO seekCEO(string email)
        {
            foreach (CEO c in CEOS)
            {
                if (c.get_email() == email)
                    return c;
            }
            return null;
        }

        public static Feedback seekFeedback(int feedbackID)
        {
            foreach (Feedback f in Feedbacks)
            {
                if (f.get_feedbackID() == feedbackID)
                    return f;
            }
            return null;
        }

        public static Workshop seekWorkshop(int ActivtyID)
        {
            foreach (Workshop w in Workshops)
            {
                if (w.Get_Activity() == ActivtyID )
                    return w;
            }
            return null;
        }

        public static Lecture seekLecture(int ActivtyID)
        {
            foreach (Lecture l in Lectures)
            {
                if (l.Get_activityID() == ActivtyID)
                    return l;
            }
            return null;
        }

        public static Booking seekBooking(int activityID, Client c)
        {
            foreach (Booking b in Bookings)
            {
                if (b.get_activityID() == activityID)
                {
                    if (b.get_email_client() == c.get_email())
                    {
                        return b;
                    }
                }
            }
            return null;
        }

        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_clients();//אתחול הרשימה של העובדים
            init_workshops();
            init_lectures();
            init_CoachingMeetings();
            init_Bookings();
            init_Feedbacks();
            init_Equipments();
            init_CEO();
        }


        public static void init_clients()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_clients";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Clients = new List<Client>();

            while (rdr.Read())
            {
                GenderType G = (GenderType)Enum.Parse(typeof(GenderType), rdr.GetValue(3).ToString());
                Client w = new Client(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), G, (DateTime)rdr.GetValue(4), rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), rdr.GetValue(12).ToString());
                Clients.Add(w);
            }
        }

        public static void init_workshops()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_workshops";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Workshops = new List<Workshop>();

            while (rdr.Read())
            {
                Workshop w = new Workshop((int)rdr.GetValue(0), rdr.GetValue(1).ToString(),(DateTime)rdr.GetValue(2), (int)rdr.GetValue(3), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), (float)rdr.GetValue(7), (DateTime)rdr.GetValue(8), (int)rdr.GetValue(9), rdr.GetValue(10).ToString(), (int)rdr.GetValue(11));
                Workshops.Add(w);
            }
        }//end init workshops


        public static void init_lectures()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Lectures";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Lectures = new List<Lecture>();

            while (rdr.Read())
            {
                LectureType L = (LectureType)Enum.Parse(typeof(LectureType), rdr.GetValue(1).ToString());
                Lecture w = new Lecture((float)rdr.GetValue(0), L, (int)rdr.GetValue(2), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), (float)rdr.GetValue(6), (DateTime)rdr.GetValue(7), (int)rdr.GetValue(8), rdr.GetValue(9).ToString(), (int)rdr.GetValue(10));
                Lectures.Add(w);
            }
        }

        public static void init_CoachingMeetings()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Get_CoachingMeetings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            CoachingMeetings = new List<CoachingMeeting>();

            while (rdr.Read())
            {
                CoachingMeeting w = new CoachingMeeting((int)rdr.GetValue(0), (DateTime)rdr.GetValue(1), (DateTime)rdr.GetValue(2), (float)rdr.GetValue(3), (int)rdr.GetValue(4), rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString());
                CoachingMeetings.Add(w);
            }
        }

        public static void init_Bookings()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Get_Bookings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Bookings = new List<Booking>();

            while (rdr.Read())
            {
                BookingStatus B = (BookingStatus)Enum.Parse(typeof(BookingStatus), rdr.GetValue(3).ToString());
                Booking w = new Booking((int)rdr.GetValue(0), (float)rdr.GetValue(1),(DateTime)rdr.GetValue(2), B, (int)rdr.GetValue(4), rdr.GetValue(5).ToString());
                Bookings.Add(w);
            }
        }

        public static void init_Equipments()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Get_Equipment";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Equipments = new List<Equipment>();

            while (rdr.Read())
            {
                WorkshopEquipment WE = (WorkshopEquipment)Enum.Parse(typeof(WorkshopEquipment), rdr.GetValue(1).ToString());
                Equipment Q = new Equipment((int)rdr.GetValue(0), WE, (int)rdr.GetValue(2), (int)rdr.GetValue(3));
                Equipments.Add(Q);
            }
        }//close init_Feedbacks
        public static void init_Feedbacks()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Get_Feedback";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Feedbacks = new List<Feedback>();

            while (rdr.Read())
            {
                Rank R = (Rank)Enum.Parse(typeof(Rank), rdr.GetValue(2).ToString());
                Feedback F = new Feedback((int)rdr.GetValue(0), (DateTime)rdr.GetValue(1), R, rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), (int)rdr.GetValue(5));
                Feedbacks.Add(F);
            }
        }//close init_Feedbacks


        public static void init_CEO()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Get_CEO";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            CEOS = new List<CEO>();

            while (rdr.Read())
            {
                GenderType GT = (GenderType)Enum.Parse(typeof(GenderType), rdr.GetValue(3).ToString());
                CEO C = new CEO(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), GT, rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString());
                CEOS.Add(C);
            }
        }//close init_CEO


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();
            Application.Run(new Main());
        }
    }
}
