using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SAD_20
{
    public class CEO
    {
        private string fullName;
        private string email;
        private string phone;
        private GenderType gender;
        private String address;
        private String aboutCEO;
        

        public CEO(string fullName, string email, string phone, GenderType gender, String address, String aboutCEO)
        {
            this.fullName = fullName;
            this.email = email;
            this.phone = phone;
            this.gender = gender;
            this.address = address;
            this.aboutCEO = aboutCEO;

        }
        //Getters
        public string get_name()
        {
            return this.fullName;
        }
        public string get_email()
        {
            return this.email;
        }
        public string get_phone()
        {
            return this.phone;
        }
        public GenderType get_gender()
        {
            return this.gender;
        }
        public String get_address()
        {
            return this.address;
        }
        public String get_aboutCEO()
        {
            return this.aboutCEO;
        }
       
        //Setters
        public void set_fullName(string name)
        {
            this.fullName = name;
        }
        public void set_email(string email)
        {
            this.email = email;
        }
        public void set_phone(string phone)
        {
            this.phone = phone;
        }
        public void set_gender(GenderType gender)
        {
            this.gender = gender;
        }
        public void set_address(String address)
        {
            this.address= address;
        }
        public void set_aboutCEO(String aboutCEO)
        {
            this.aboutCEO= aboutCEO;
        }

  

    }
}
