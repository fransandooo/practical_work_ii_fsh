namespace PracticalWorkII
{
    public partial class Login : Form
    {

        List<Users> users = new List<Users>(); //list to store the info of the users that are going to be created


        string usernamelog; //variable to store the username that the user puts while loging in
        string passwordlog; //variable to store the password that the user puts while loging in
        public string registerfile = @"infousers.txt"; //string to store the txt file name where the info of the users is stored in my program
        public string userloged { get; set; } //variable to store the name of the user that logged in

        public Login(State s1)
        {
            this.state = s1;

            loadUsers(); //i call the method that loads the users info from the txt file

            InitializeComponent();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//this is the button that the user will press to login
        {
            bool loginsuccess = false;//variable to store if the login was successful or not, to create a loop so that we know when to stop the login process

            loginsuccess = tryLogin(); //i call the method that will try to login the user and store the result in the variable loginsuccess, because the method is a bool type so it will return true or false

            if (loginsuccess == true)
            {
                this.state.ChangeSate(3);
                this.Close();

            }


        }

        public bool tryLogin()//method to try to login the user
        {
            usernamelog = usernameBox.Text; // variables to store the info of the text box that the user inputs
            passwordlog = passwordBox.Text;

            foreach (Users u in users) // foreach to go through each of the elements of the list of users
            {
                if (u.getUserName() == usernamelog) // check if the username of the user in the list is the same as the one that the user input
                {
                    if (u.getPassword() == passwordlog) // check if the password matches
                    {
                        MessageBox.Show("Welcome " + u.getName()); // message to show that the user logged in
                        userloged = u.getUserName(); // store the name of the user that logged in
                        return true;// return true to stop the loop, because the user was found inside our list of users and the password matched
                    }
                    else
                    {
                        MessageBox.Show("Wrong password for the user: " + usernamelog); // message to show that the user input the wrong password
                        return false;//return false because the password was wrong
                    }
                }
            }

            MessageBox.Show("User not found"); // message to show that the user does not exist
            return false;//return false because the user was not found in the list of users

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//link to go to the register form so i do it by changing the state to 2 and closing this form
        {
            this.state.ChangeSate(2);
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//link to go to the change password form so i do it by changing the state to 4 and closing this form
        {
            this.state.ChangeSate(4);
            this.Close();


        }



        public void loadUsers() // method to load the users info from the txt file
        {
            StreamReader sr = new StreamReader(registerfile); // i open the txt file stored in the string registerfile

            try
            {

                string counterlines; // string to store each of the lines of the txt file

                while ((counterlines = sr.ReadLine()) != null) // used to make this run everytime there is the file existing, in case the file doesnt exits
                {

                    string[] data = counterlines.Split(';'); //i add an array string that will store the data from the line separated into elements by the separator ;, so i can the access them
                                                            //separately

                    users.Add(new Users(data[0], data[1], data[2], data[3], Int32.Parse(data[4]))); //this creates a new user with the data that was stored in the array data, and adds it to the list of users,
                    //because the data[0] is the name of the user, data[1] is the username, data[2] is the password, data[3] is the email and data[4] is the number of operations that the user has done, and i give it to the instance
                    //of the class Users that im creating, and saving in the list of users
                }


            }
            catch (Exception e)// in case there is an error with the file it will show a message box with the error
            {
                MessageBox.Show("Error: " + e.Message);
            }

            sr.Close(); // i close the txt file

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.state.ChangeSate(0);// i change the state to 0 to exit the programm
            this.Close(); // i close this form

        }
    }
}
