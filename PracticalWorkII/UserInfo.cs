using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalWorkII
{
    public partial class UserInfo : Form
    {
        protected string username;//variable to store the name of the user that logged in

        List<Users> users = new List<Users>(); //list to store the info of the users that are going to be created

        public string registerfile = @"infousers.txt";//string to store the txt file I use to store the info of each user,
        public UserInfo(State s1, string username)
        {
            this.state = s1;
            this.username = username;

            loadUsers();//i call the method that loads the users info from the txt file

            InitializeComponent();

            loadSpecificUser();//i call the method that loads the specific user that is logged in
        }



        public void loadUsers()//method to load the users from the txt file, same as the one in the register form
        {
            StreamReader sr = new StreamReader(registerfile); // i open the txt file stored in the string registerfile

            try
            {

                string counterlines; // string to store each of the lines of the txt file

                while ((counterlines = sr.ReadLine()) != null) // used to make this run everytime there is the file existing, in case the file doesnt exits
                {

                    string[] data = counterlines.Split(';'); 

                    users.Add(new Users(data[0], data[1], data[2], data[3], Int32.Parse(data[4]))); //this adds the elements of info string to the users list of strings that i created at the start


                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            sr.Close(); // i close the txt file
        }

        public void loadSpecificUser()//method to load the specific user that is logged in
        {
            foreach (Users u in users)//foreach to go through each of the elements of the list of users
            {
                if (u.getUserName() == this.username)//if the username of the user that is in the list is the same as the one that is logged in, i show the info of that user by changing the text of the labels
                {
                    NameLabel.Text += u.getName();
                    EmailLabel.Text += u.getEmail();
                    UsernameLabel.Text += u.getUserName();
                    PasswordLabel.Text += u.getPassword();
                    OperationsLabel.Text += u.getNumberOperations().ToString();
                }
            }
        }

        public void SaveUsers()//method to save the users info in the txt file, same as the one in the register form
        {
            StreamWriter sw = new StreamWriter(registerfile); // i open the txt file

            foreach (Users u in users) //foreach to go through each of the elements of the list of users
            {
                sw.WriteLine(u.getName() + ";" + u.getUserName() + ";" + u.getPassword() + ";" + u.getEmail() + ";" + u.getNumberOperations()); // i write a line with the email of the user and its passwords with the variables that I stored them and with a $ in between wich will be the separator
            }

            sw.Close(); //I close the txt file
        }


        public bool changeDataUser()//method to change the data of the user that is logged in
        {

            string newname = newNameBox.Text;//variables to store the new data that is going to be changed
            string newemail = newEmailBox.Text;
            string newusername = newUsernameBox.Text;
            string newpassword = newPasswordBox.Text;

            if(newname == "" || newemail == "" || newusername == "" || newpassword == "")//if any of the fields is empty, it will show a message box
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }

            foreach (Users u in users)
            {
                if (u.getUserName() == this.username)//if the username of the user that is in the list is the same as the one that is logged in, i change the data of that user
                {
                    u.setName(newname);
                    u.setEmail(newemail);
                    u.setUserName(newusername);
                    u.setPassword(newpassword);
                    return true;
                }
            }

            return false;
            
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void OperationsLabel_Click(object sender, EventArgs e)
        {

        }

        private void newNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newEmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateInfoButton_Click(object sender, EventArgs e)//button to update the info of the user that is logged in
        {
            bool datachanged = false;//variable to store if the data was changed



            datachanged = changeDataUser();

            if (datachanged == true)//if the data was changed, it will save the users info and close the form
            {
                SaveUsers();// i call the method that saves the users info in the txt file

                this.state.ChangeSate(1);//i change the state to 1 to open the login form
                this.Close();

            }


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.state.ChangeSate(0);
            this.Close(); // i close this form
        }
    }
}
