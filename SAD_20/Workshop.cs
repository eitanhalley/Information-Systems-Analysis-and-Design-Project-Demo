using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SAD_20
{

    public class Workshop
    {
        private int NumOfMeetings;
        private string Repetivity;
        private DateTime EndDate;
        private int ActivityID;
        private String Email;
        private String name;
        private String description;
        private Double price;
        private DateTime startDate;
        private int capacity;
        private String location;
        private int seatsLeft;
        public System.Collections.Generic.List<Equipment> Equipments;

        public Workshop(int NumOfMeetings, string Repetivity, DateTime EndDate, int ActivityID, String Email, String name, String description, Double price, DateTime startDate, int capacity, String location, int seatsLeft)
        {
            this.NumOfMeetings = NumOfMeetings;
            this.Repetivity = "Every " + Repetivity;
            this.EndDate = EndDate;
            this.ActivityID = ActivityID;
            this.Email = Email;
            this.name = name;
            this.description = description;
            this.price = price;
            this.startDate = startDate;
            this.capacity = capacity;
            this.location = location;
            this.seatsLeft = seatsLeft;

            //Getters
        }//workshop
        public int get_NumOfMeetings()
        {
            return this.NumOfMeetings;
        }//NumOfMeetings
        public string Get_Repetivity()
        {
            return this.Repetivity;
        }//get_Repetivity

        public DateTime Get_EndDate()
        {
            return this.EndDate;
        }//get_DateTime

        public int Get_Activity()
        {
            return this.ActivityID;
        }//get_DateTime

        public String Get_Email()
        {
            return this.Email;
        }//get_Email

        public String Get_name()
        {
            return this.name;
        }

        public string Get_descripton()
        {
            return this.description;
        }

        public Double Get_price()
        {
            return this.price;
        }

        public DateTime Get_startDate()
        {
            return this.startDate;
        }

        public int Get_capacity()
        {
            return this.capacity;
        }

        public String Get_location()
        {
            return this.location;
        }

        public int Get_seatsLeft()
        {
            return this.seatsLeft;
        }

        public void Set_NumOfMeetings(int NumOfMeetings)
        {
            this.NumOfMeetings = NumOfMeetings;
        }//set_NumofMeetings

        public void Set_Repetivity(String Repetivity)
        {
            this.Repetivity = Repetivity;
        }//set_Repetivity

        public void Set_EndDate(DateTime EndDate)
        {
            this.EndDate = EndDate;
        }//set_EndDate

        public void Set_Activity(int ActivityID)
        {
            this.ActivityID = ActivityID;
        }//set_Activity

        public void Set_Email(String Email)
        {
            this.Email = Email;
        }//set_Email

        public void Set_name(String name)
        {
            this.name = name;
        }//Set_name

        public void Set_description(string description)
        {
            this.description = description;
        }//Set_descript

        public void Set_price(Double price)
        {
            this.price = price;
        }//Set_price

        public void Set_startDate(DateTime startDate)
        {
            this.startDate = startDate;
        }//Set_startDate

        public void Set_capacity(int capacity)
        {
            this.capacity = capacity;
        }//Set_capacity

        public void Set_location(String location)
        {
            this.location = location;
        }//Set_location

        public void Get_seatsLeft(int seatsLeft)
        {
            this.seatsLeft = seatsLeft;
        }//Set_seatsLeft

        public void create_workshop()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_workshop @NumOfMeetings, @Repetivity, @EndDate, @ActivityID, @Email, @name, @description, @price, @startDate, @capacity, @location, @seatsLeft";
            c.Parameters.AddWithValue("@NumOfMeetings", this.NumOfMeetings);
            c.Parameters.AddWithValue("@Repetivity", this.Repetivity);
            c.Parameters.AddWithValue("@EndDate", this.EndDate);
            c.Parameters.AddWithValue("@ActivityID", this.ActivityID);
            c.Parameters.AddWithValue("@Email", this.Email);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@description", this.description);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@startDate", this.startDate);
            c.Parameters.AddWithValue("@capacity", this.capacity);
            c.Parameters.AddWithValue("@location", this.location);
            c.Parameters.AddWithValue("@seatsLeft", this.seatsLeft);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_workshop()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Workshop @id, @NumOfMeetings, @Repetivity, @EndDate, @Email, @name, @description, @price, @startDate, @capacity, @location, @seatsLeft";
            c.Parameters.AddWithValue("@id", this.ActivityID);
            c.Parameters.AddWithValue("@NumOfMeetings", this.NumOfMeetings);
            c.Parameters.AddWithValue("@Repetivity", this.Repetivity);
            c.Parameters.AddWithValue("@EndDate", this.EndDate);
            c.Parameters.AddWithValue("@Email", this.Email);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@description", this.description);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@startDate", this.startDate);
            c.Parameters.AddWithValue("@capacity", this.capacity);
            c.Parameters.AddWithValue("@location", this.location);
            c.Parameters.AddWithValue("@seatsLeft", this.seatsLeft);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void delete_workshop()
        {
            Program.Workshops.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_workshop @activityID";
            c.Parameters.AddWithValue("@ActivityID", this.ActivityID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }//Workshop
}//SAD_20
