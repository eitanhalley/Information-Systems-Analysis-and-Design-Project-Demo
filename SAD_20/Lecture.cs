using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SAD_20
{
    public class Lecture
    {
        private Double duration;
        private LectureType lectureType;
        private int activityID;
        private String email;
        private String name;
        private String description;
        private Double price;
        private DateTime startDate;
        private int capacity;
        private String location;
        private int seatsLeft;


        public Lecture(Double duration, LectureType lectureType, int activityID, String email, String name, String description, Double price, DateTime startDate, int capacity, String location, int seatsLeft)
        {
            this.duration = duration;
            this.lectureType = lectureType;
            this.activityID = activityID;
            this.email = email;
            this.name = name;
            this.description = description;
            this.price = price;
            this.startDate = startDate;
            this.capacity = capacity;
            this.location = location;
            this.seatsLeft = seatsLeft;
        }//Constructor

        //Getters
        public Double Get_duration()
        {
            return this.duration;
        }

        public LectureType Get_lectureType()
        {
            return this.lectureType;
        }

        public int Get_activityID()
        {
            return this.activityID;
        }

        public String Get_email()
        {
            return this.email;
        }

        public String Get_name()
        {
            return this.name;
        }

        public String Get_descripton()
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

        //Setters
        public void Set_duration(Double duration)
        {
            this.duration = duration;
        }//Set_meetingDate

        public void Set_LectureType(LectureType lectureType)
        {
            this.lectureType = lectureType;
        }//Set_lectureType

        public void Set_activityID(int activityID)
        {
            this.activityID = activityID;
        }//Set_activityDate

        public void Set_email(String email)
        {
            this.email = email;
        }//Set_email

        public void Set_name(String name)
        {
            this.name = name;
        }//Set_name

        public void Set_description(String description)
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

        public void Set_seatsLeft(int seatsLeft)
        {
            this.seatsLeft = seatsLeft;
        }//Set_seatsLeft

        public void updateSeats(int n)
        {
            if (seatsLeft > 0 & seatsLeft < capacity)
            {
                this.seatsLeft = seatsLeft + n;
                update_lecture();
            }
        }


        public void create_lecture()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Lecture @duration, @lectureType, @activityID, @Email, @name, @Description, @price, @startDate, @capacity, @location, @seatsLeft";
            c.Parameters.AddWithValue("@duration", this.duration);
            c.Parameters.AddWithValue("@lectureType", this.lectureType.ToString());
            c.Parameters.AddWithValue("@activityID", this.activityID);
            c.Parameters.AddWithValue("@email", this.email);
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

        public void update_lecture()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Lecture @id, @duration,@lectureType,@Email, @name, @description, @price, @startDate, @capacity, @location, @seatsLeft";
            c.Parameters.AddWithValue("@id", this.activityID);
            c.Parameters.AddWithValue("@duration", this.duration);
            c.Parameters.AddWithValue("@lectureType", this.lectureType.ToString());
            c.Parameters.AddWithValue("@Email", this.email);
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

        public void delete_lecture()
        {
            Program.Lectures.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_Lecture @activityID";
            c.Parameters.AddWithValue("@activityID", this.activityID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }//Lecture class
}//Name space
