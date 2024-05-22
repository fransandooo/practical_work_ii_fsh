using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Register : Form
    {
        string registerfile = @"infousers.txt"; //string to store the info of the txt that i created
        protected string nameregist; //string to store the info of the text box of the name
        protected string usernameregist;//string to store the info of the text box of the username
        protected string passwordregist;//string to store the info of the text box of the first password
        protected string password2;//string to store the info of the text box of the second time it puts the password
        protected string emailregist;//string to store the info of the text box of the email

        List<Users> users = new List<Users>(); //list to store the info of the users that are going to be created

        public Register(State s1)
        {
            this.state = s1;

            loadUsers(); //i call the method that loads the users info from the txt file into the list of users, as we did in the login form

            InitializeComponent();
        }



        private void NameBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RepeatPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void RegisterButton_Click(object sender, EventArgs e)//method that is called when the register button is clicked
        {
            bool registerSuccess = false;//variable to store the result of the method that tries to register the user

            registerSuccess = tryRegister();//i call the method that tries to register the user

            if (registerSuccess == true)
            {
                MessageBox.Show("You have been registered successfully"); //message to show that the user has been registered successfully
                SaveUsers(); // i call the method that will save the users info in the txt file

                this.state.ChangeSate(1); // i open the login form with the states
                this.Close(); // i close this form
            }





        }



        private void Register_Load(object sender, EventArgs e)
        {

        }


        public bool tryRegister()//method that tries to register the user
        {

            nameregist = NameBox.Text;// it take what the user input in the name text box and put it in the variable that i created before
            usernameregist = UsernameBox.Text;// it take what the user input in the username text box and put it in the variable that i created before
            passwordregist = PasswordBox.Text;// it take what the user input in the password text box and put it in the variable that i created before
            password2 = RepeatPasswordBox.Text;// it take what the user input in the second password text box and put it in the variable that i created before
            emailregist = EmailBox.Text;// it take what the user input in the email text box and put it in the variable that i created before

            if (string.IsNullOrEmpty(nameregist) || string.IsNullOrEmpty(usernameregist) || string.IsNullOrEmpty(passwordregist) || string.IsNullOrEmpty(password2)) //if to make sure that the user doesnt leave any text box empty to make suer it doesnt create a user with empty email and empty password
            {

                MessageBox.Show("You forgot to fill something"); //messge to show that the user left an empty box

                return false;

            }
            else if (password2 != passwordregist) //if in case the password and the repeat password are not the same so the user is force to put the same password twice
            {
                MessageBox.Show("The passwords do not match"); //message box to alert of this

                PasswordBox.Clear();
                RepeatPasswordBox.Clear();

                return false;
            }
            else if (checkBox1.Checked == false)//if in case the user doesnt check the policy terms
            {

                MessageBox.Show("Please check the policy terms "); //message box to alert of this

                return false;

            }
            else //in case the user did everything right 
            {

                users.Add(new Users(nameregist, usernameregist, passwordregist, emailregist, 0)); //i add the user to the list of users, and set the intial number of operations to 0

                return true;


            }
        }



        public void SaveUsers()//function to save the users info in the txt file
        {
            StreamWriter sw = new StreamWriter(registerfile); // i open the txt file

            foreach (Users u in users) //foreach to go through each of the elements of the list of users
            {
                sw.WriteLine(u.getName() + ";" + u.getUserName() + ";" + u.getPassword() + ";" + u.getEmail() + ";" + u.getNumberOperations()); // i write a line in the txt file with the infor of the user, that i take using the getters of the class Users, and i separate each of the elements with a ; to make it easier to read the txt file
            }

            sw.Close(); //I close the txt file
        }


        public void loadUsers()//same funcion as in the login form
        {
            StreamReader sr = new StreamReader(registerfile); // i open the txt file stored in the string registerfile

            try
            {

                string counterlines; // string to store each of the lines of the txt file

                while ((counterlines = sr.ReadLine()) != null) // used to make this run everytime there is the file existing, in case the file doesnt exits
                {

                    string[] data = counterlines.Split(';'); 

                    users.Add(new Users(data[0], data[1], data[2], data[3], Int32.Parse(data[4])));
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            sr.Close(); // i close the txt file

        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//method that is called when the link label is clicked to go back to the login form
        {
            this.state.ChangeSate(1);

            this.Close();


        }

        private void buttonExit_Click(object sender, EventArgs e)//method that is called when the exit button is clicked, to close the form
        {
            this.state.ChangeSate(0);
            this.Close(); // i close this form


        }
    }


}

