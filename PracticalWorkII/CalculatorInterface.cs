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
    public partial class CalculatorInterface : Form //class to create the calculator interface
    {
        protected string username; //variable to store the username of the user that is going to use the calculator

        protected int operations = 0; //variable to store the number of operations that the user has done

        List<Users> users = new List<Users>(); //list to store the info of the users that are going to be created

        public string registerfile = @"infousers.txt"; //string to store the name of the txt file where the info of the users is going to be stored


        public CalculatorInterface(State s1, string username)
        {

            this.state = s1;

            this.username = username; // i store the username that i received from the login form in the variable username

            loadUsers();// i call the method that loads the users info from the txt file

            InitializeComponent();

        }

        private void CalculatorInterface_Load(object sender, EventArgs e)
        {

        }

        private void CalculatorTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        //this methods are used to add the numbers or the signs into the calculator textbox, the only this that changes is that for the sign we have spaces between the numbers and the sign
        private void button1_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "1";
            }
            else
            {
                CalculatorTextBox.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "2";
            }
            else
            {
                CalculatorTextBox.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "3";
            }
            else
            {
                CalculatorTextBox.Text += "3";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "4";
            }
            else
            {
                CalculatorTextBox.Text += "4";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "5";
            }
            else
            {
                CalculatorTextBox.Text += "5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "6";
            }
            else
            {
                CalculatorTextBox.Text += "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "7";
            }
            else
            {
                CalculatorTextBox.Text += "7";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "8";
            }
            else
            {
                CalculatorTextBox.Text += "8";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "9";
            }
            else
            {
                CalculatorTextBox.Text += "9";
            }

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "0";
            }
            else
            {
                CalculatorTextBox.Text += "0";
            }

        }

        private void buttonSign_Click(object sender, EventArgs e)
        {


        }

        private void buttonComa_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "0.";
            }
            else
            {
                CalculatorTextBox.Text += ".";
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "0";
            }
            else
            {
                CalculatorTextBox.Text += " + ";
            }

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "0";
            }
            else
            {
                CalculatorTextBox.Text += " - ";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "0";
            }
            else
            {
                CalculatorTextBox.Text += " * ";
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "0";
            }
            else
            {
                CalculatorTextBox.Text += " / ";
            }

        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "0";
            }
            else
            {
                CalculatorTextBox.Text += " ^ ";
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {

            if (CalculatorTextBox.Text == "0")
            {
                CalculatorTextBox.Text = "0";
            }
            else
            {
                CalculatorTextBox.Text += " % ";
            }

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            string result = calculator.PerformOperation(CalculatorTextBox.Text);
            CalculatorTextBox.Text = result;

            operations++; // i add one to the number of operations that the user has done

        }

        private void buttonCero_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text = "0";
        }

        private void UserInfoButton_Click(object sender, EventArgs e)//this method is used to open the user info form
        {

            changeDataUser();//so before opening the user info form i change the number of operations that the user has done
            SaveUsers();//and i save the users info, from the list of users that i created into the txt file
            this.state.ChangeSate(5);
            this.Close(); // i close this form
        }

        private void buttonExit_Click(object sender, EventArgs e)//this method is used to close the form
        {

            changeDataUser();//so before closing the form i change the number of operations that the user has done
            SaveUsers();//and i save the users info, from the list of users that i created into the txt file
            this.state.ChangeSate(0);
            this.Close(); // i close this form

        }




        public void loadUsers()//same as in the login form
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

        public void SaveUsers()//same as in the register form
        {
            StreamWriter sw = new StreamWriter(registerfile); // i open the txt file

            foreach (Users u in users) //foreach to go through each of the elements of the list of users
            {
                sw.WriteLine(u.getName() + ";" + u.getUserName() + ";" + u.getPassword() + ";" + u.getEmail() + ";" + u.getNumberOperations()); // i write a line with the email of the user and its passwords with the variables that I stored them and with a $ in between wich will be the separator
            }

            sw.Close(); //I close the txt file
        }


        public void changeDataUser()//this method is used to change the number of operations that the user has done, i use the setters and getters to change the number of operations
        {


            foreach (Users u in users)
            {
                if (u.getUserName() == this.username)
                {
                    u.setNumberOperations(operations);
                    
                }
            }
        }

    }
}
