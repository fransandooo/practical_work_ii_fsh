using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII
{
    public class Users//class that stores the info of the users
    {
        //variables that store the info of the users
        protected string name;
        protected string username;
        protected string password;
        protected string email;
        protected int numberoperations;


        public Users(string name, string username, string password, string email, int numberoperations)//constructor of the class
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
            this.numberoperations = numberoperations;
        }

        //methods to set and get the variables of the class
        public void setName(string name)
        {
            this.name = name;
        }   
        public void setUserName(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setNumberOperations(int numberoperations)
        {
            this.numberoperations += numberoperations;
        }

        public string getName()
        {
            return this.name;
        }
        public string getUserName()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getEmail()
        {
            return this.email;
        }
        public int getNumberOperations()
        {
            return this.numberoperations;
        }
       

    }
}
