﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SAD_20
{
    class CoachingMeeting
    {
        private int meetingID;
        private DateTime bookingDate;
        private DateTime meetingDate;
        private double price;
        private int meetingNum;
        private String emailClient;
        private String email;

        public CoachingMeeting(int meetingID, DateTime bookingDate, DateTime meetingDate, double price,
            int meetingNum, String emailClient, String email)
        {
            this.meetingID = meetingID;
            this.bookingDate = bookingDate;
            this.meetingDate = meetingDate;
            this.price = price;
            this.meetingNum = meetingNum;
            this.emailClient = emailClient;
            this.email = email;
        }//constructor

        //Getters
        public int Get_meetingID()
        {
            return this.meetingID;
        }//get_meetingID

        public DateTime Get_bookingDate()
        {
            return this.bookingDate;
        }//get_bookingDate

        public DateTime Get_meetingDate()
        {
            return this.meetingDate;
        }//get_meetingDate

        public Double Get_price()
        {
            return this.price;
        }//get_price

        public int Get_meetingNum()
        {
            return this.meetingNum;
        }//get_meetingNum

        public String Get_emailClient()
        {
            return this.emailClient;
        }//get_emailClient

        public String Get_email()
        {
            return this.email;
        }//get_email

        //Setters
        public void set_meetingID(int meetingID)
        {
            this.meetingID = meetingID;
        }//set_meetingID

        public void set_bookingDate(DateTime bookingDate)
        {
            this.bookingDate = bookingDate;
        }//set_bookingDate

        public void Set_meetingDate(DateTime meetingDate)
        {
            this.meetingDate = meetingDate;
        }//Set_meetingDate

        public void Set_price(double price)
        {
            this.price = price;
        }//Set_price

        public void Set_meetingNum(int meetingNum)
        {
            this.meetingNum = meetingNum;
        }//Set_meetingNum

        public void Set_emailClient(String emailClient)
        {
            this.emailClient = emailClient;
        }//Set_emailClient

        public void Set_email(String email)
        {
            this.email = email;

        }//Set_email


        public void create_coachingMeeting()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_coachingMeetings @meetingID, @bookingDate, @meetingDate, @price, @meetingNum, @email_client, @email";
            c.Parameters.AddWithValue("@meetingID", this.meetingID);
            c.Parameters.AddWithValue("@bookingDate", this.bookingDate);
            c.Parameters.AddWithValue("@meetingDate", this.meetingDate);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@meetingNum", this.meetingNum);
            c.Parameters.AddWithValue("@email_client", this.emailClient);
            c.Parameters.AddWithValue("@email", this.email);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        public void delete_coachingMeeting()
        {
            Program.CoachingMeetings.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_coachingMeetings @meetingID, @email_client, @email";
            c.Parameters.AddWithValue("@meetingID", this.meetingID);
            c.Parameters.AddWithValue("@email_client", this.emailClient);
            c.Parameters.AddWithValue("@email", this.email);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }//CoachMeeting
}//SAD_20
