using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//חשוב!

namespace SAD_20
{
    public class Client
    {
        private string fullName;
        private string email_client;
        private string phone;
        private GenderType gender;
        private DateTime birthDate;
        private string addressCountry;
        private string addressCity;
        private int numOfCoachingMeetings;
        private int numOfWorkshops;
        private int numOfLectures;
        private double discount;
        private DateTime lastActivityDate;
        private string password;

        public Client(string fullName, string email, string phone, GenderType gender, DateTime birthDate, string country, string city, string password)
        {
            this.fullName = fullName;
            this.email_client = email;
            this.phone = phone;
            this.gender = gender;
            this.birthDate = birthDate;
            this.addressCountry = country;
            this.addressCity = city;
            numOfCoachingMeetings = 0;
            numOfLectures = 0;
            numOfWorkshops = 0;
            discount = 0;
            lastActivityDate = DateTime.Now;
            this.password = password;

        }
        //Getters
        public string get_name()
        {
            return this.fullName;
        }
        public string get_email()
        {
            return this.email_client;
        }
        public string get_phone()
        {
            return this.phone;
        }
        public GenderType get_gender()
        {
            return this.gender;
        }
        public DateTime get_birthDate()
        {
            return this.birthDate;
        }
        public string get_addressCountry()
        {
            return this.addressCountry;
        }
        public string get_addressCity()
        {
            return this.addressCity;
        }
        public int get_numOfCoachinigMeetings()
        {
            return this.numOfCoachingMeetings;
        }
        public int get_numOfWorkshops()
        {
            return this.numOfWorkshops;
        }
        public int get_numOfLectures()
        {
            return this.numOfLectures;
        }
        public double get_discount()
        {
            return this.discount;
        }
        public DateTime get_lastActivityDate()
        {
            return this.lastActivityDate;
        }
        public string get_password()
        {
            return this.password;
        }
        //Setters
        public void set_fullName(string name)
        {
            this.fullName = name;
        }
        public void set_email(string email)
        {
            this.email_client = email;
        }
        public void set_phone(string phone)
        {
            this.phone = phone;
        }
        public void set_gender(GenderType gender)
        {
            this.gender = gender;
        }
        public void set_birthDate(DateTime date)
        {
            this.birthDate = date;
        }
        public void set_addressCountry(string country)
        {
            this.addressCountry = country;
        }
        public void set_addressCity(string city)
        {
            this.addressCity = city;
        }
        public void set_numOfCoachinigMeetings(int num)
        {
            this.numOfCoachingMeetings = num;
        }
        public void set_numOfWorkshops(int num)
        {
            this.numOfWorkshops = num;
        }
        public void set_numOfLectures(int num)
        {
            this.numOfLectures = num;
        }
        public void set_discount(double discount)
        {
            this.discount = discount;
        }
        public void set_lastActivityDate(DateTime date)
        {
            this.lastActivityDate = date;
        }
        public void set_password(string password)
        {
            this.password = password;
        }

        public void addLecture()
        {
            this.numOfLectures = this.numOfLectures + 1;
            update_client();
        }

        public void removeLecture()
        {
            this.numOfLectures = this.numOfLectures - 1;
            update_client();
        }

        public void create_client()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_client @fullname, @client_email, @phone, @Gender, @Birthdate, @AddressCountry, @AddressCity, @NumofCoachingMeetings, @NumofWorkshops, @NumofLectures, @Discount, @LastActivityDate, @Password";
            c.Parameters.AddWithValue("@fullname", this.fullName);
            c.Parameters.AddWithValue("@client_email", this.email_client);
            c.Parameters.AddWithValue("@phone", this.phone);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@Birthdate", this.birthDate);
            c.Parameters.AddWithValue("@AddressCountry", this.addressCountry);
            c.Parameters.AddWithValue("@AddressCity", this.addressCity);
            c.Parameters.AddWithValue("@NumofCoachingMeetings", this.numOfCoachingMeetings);
            c.Parameters.AddWithValue("@NumofWorkshops", this.numOfWorkshops);
            c.Parameters.AddWithValue("@NumofLectures", this.numOfLectures);
            c.Parameters.AddWithValue("@Discount", this.discount);
            c.Parameters.AddWithValue("@LastActivityDate", this.lastActivityDate);
            c.Parameters.AddWithValue("@Password", this.password);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_client()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Client  @fullName, @email_client, @phone, @gender, @birthDate, @addressCountry, @addressCity, @numOfCoachingMeeting, @NumOfWorkshops, @NumOfLectures, @Discount, @LastActivityDate, @password";
            c.Parameters.AddWithValue("@fullName", this.fullName);
            c.Parameters.AddWithValue("@email_client", this.email_client);
            c.Parameters.AddWithValue("@phone", this.phone);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@birthDate", this.birthDate);
            c.Parameters.AddWithValue("@addressCountry", this.addressCountry);
            c.Parameters.AddWithValue("@addressCity", this.addressCity);
            c.Parameters.AddWithValue("@numOfCoachingMeeting", this.numOfCoachingMeetings);
            c.Parameters.AddWithValue("@numOfWorkshops", this.numOfWorkshops);
            c.Parameters.AddWithValue("@numOfLectures", this.numOfLectures);
            c.Parameters.AddWithValue("@Discount", this.discount);
            c.Parameters.AddWithValue("@lastActivityDate", this.lastActivityDate);
            c.Parameters.AddWithValue("@password", this.password);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void delete_client()
        {
            Program.Clients.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_Client @email_client";
            c.Parameters.AddWithValue("@email_client", this.email_client);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
