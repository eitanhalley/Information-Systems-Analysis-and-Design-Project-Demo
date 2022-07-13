using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SAD_20
{
    public class Booking
    {
        private int bookingID;
        private double price;
        private DateTime bookingDate;
        private BookingStatus bookingStatus;
        private int activityID;
        private string email_client;

        public Booking(int id, double price, DateTime date, BookingStatus status, int activityID, string email)
        {
            this.bookingID = id;
            this.price = price;
            this.bookingDate = date;
            this.bookingStatus = status;
            this.activityID = activityID;
            this.email_client = email;
        }

        //Getters
        public int get_bookingID()
        {
            return bookingID;
        }
        public double get_price()
        {
            return price;
        }
        public DateTime get_bookingDate()
        {
            return bookingDate;
        }
        public BookingStatus get_bookingStatus()
        {
            return bookingStatus;
        }
        public int get_activityID()
        {
            return activityID;
        }
        public string get_email_client()
        {
            return email_client;
        }

        //Setters
        public void set_bookingID(int bookingID)
        {
            this.bookingID = bookingID;
        }
        public void set_price(double price)
        {
            this.price = price;
        }
        public void set_bookingDate(DateTime date)
        {
            this.bookingDate = date;
        }
        public void set_bookingStatus(BookingStatus status)
        {
            this.bookingStatus = status;
        }
        public void set_activityID(int id)
        {
            this.activityID = id;
        }
        public void set_email_client(string email)
        {
            this.email_client = email;
        }

        public bool IsFeedbackedAlready()
        {
            foreach (Feedback f in Program.Feedbacks)
            {
                if((f.get_activityID() == this.activityID) && (f.get_email_client().Equals(this.email_client)))
                {
                    return true;
                }    
            }
            return false;
        }

        public void create_booking()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_bookings @bookingID, @price, @bookingDate, @bookingStatus, @activityID, @email_client";
            c.Parameters.AddWithValue("@bookingID", this.bookingID);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@bookingDate", this.bookingDate);
            c.Parameters.AddWithValue("@bookingStatus", this.bookingStatus.ToString());
            c.Parameters.AddWithValue("@activityID", this.activityID);
            c.Parameters.AddWithValue("@email_client", this.email_client);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        public void delete_booking()
        {
            Program.Bookings.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_bookings @bookingID, @activityID, @email_client";
            c.Parameters.AddWithValue("@bookingID", this.bookingID);
            c.Parameters.AddWithValue("@activityID", this.activityID);
            c.Parameters.AddWithValue("@email_client", this.email_client);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }

}
