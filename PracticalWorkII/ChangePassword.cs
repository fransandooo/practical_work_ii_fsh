using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalWorkII
{
    public partial class ChangePassword : Form
    {

        List<Users> users = new List<Users>(); //list to store the info of the users that are going to be created

        protected string namelog;
        protected string usernamelog; //variable to store the email that the user puts while loging in
        protected string newpasswordlog; //variable to store the password that the user puts while loging in
        protected string registerfile = @"infousers.txt"; //string to store the txt file I use to store the info of each user,
                                                          //I couldnt make it to use the same variable that i created in the register form,
                                                          //so i created a new variables that takes the same path where the register form stored the file when created */


        public ChangePassword(State s1)
        {
            this.state = s1;

            loadUsers(); //i call the method that loads the users info from the txt file

            InitializeComponent();
        }

        private void ChnagePassword_Load(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.state.ChangeSate(1);

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool passwordChanged = false;

            passwordChanged = tryChangePassword();

            if (passwordChanged == true)
            {

                SaveUsers(); // llama al método que guarda la información de los usuarios en el archivo de texto

                this.state.ChangeSate(1);
                this.Close();
            }

        }


        public void loadUsers()//method to load the users info from the txt file, same as the one in the register form
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

        public bool tryChangePassword()//method to try to change the password of the user
        {
            namelog = NametextBox.Text; 
            usernamelog = UsernameBox.Text; 
            newpasswordlog = NewPasswordBox.Text; 

            foreach (Users u in users) // it goes through each of the elements of the list of users
            {
                if (u.getUserName() == usernamelog && u.getName() == namelog)
                {
                    u.setPassword(newpasswordlog); // usses the setter of the password to change the password of the user
                    MessageBox.Show("Password changed correctly for: " + u.getName());
                    return true;
                }
            }


            MessageBox.Show("The username or name doesn't match any user in our records. Please try again.");
            NametextBox.Clear();
            UsernameBox.Clear();
            NewPasswordBox.Clear();
            return false;
        }



        public void SaveUsers()
        {
            StreamWriter sw = new StreamWriter(registerfile); // i open the txt file

            foreach (Users u in users) //foreach to go through each of the elements of the list of users
            {
                sw.WriteLine(u.getName() + ";" + u.getUserName() + ";" + u.getPassword() + ";" + u.getEmail() + ";" + u.getNumberOperations()); // i write a line with the email of the user and its passwords with the variables that I stored them and with a $ in between wich will be the separator
            }

            sw.Close(); //I close the txt file
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.state.ChangeSate(0);
            this.Close(); // i close this form
        }
    }
}
