using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PracticalWorkII
{
    public static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            //This methods are called automatically by the Windows Form Net framework, the only thing that I took out is the method that directly open the Menu form because im using the state class for that.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            State s1 = new State(); // I initiate the state class bacouse is the one in charge of managing the forms (opening,hiding and closing)

            string userloged = "";//variable to store the name of the user that logged in

            while (s1.GetSate() != 0) //this loops is made to always do whats inside of it except when state is equal to 0, because when the state is equal to 0 it will stop.
            {
                switch (s1.GetSate()) // switch used to put all the forms that im going to use and deoending on the value of the state it will open one form or another
                {
                    case 1:
                        Login login = new Login(s1);// i create the login form

                        Application.Run(login);// i run the login form
                        
                        userloged = login.userloged;// i store the name of the user that logged in from the userloged variable that is in the login form
                        break;
                    case 2:
                        Application.Run(new Register(s1));// i run the register form
                        break;
                    case 3:
                        Application.Run(new CalculatorInterface(s1, userloged));// i run the calculator form, and i pass the name of the user that logged in, to use it later for some methods
                        break;
                    case 4:
                        Application.Run(new ChangePassword(s1));// i run the change password form
                        break;
                    case 5:
                        Application.Run(new UserInfo(s1, userloged));// i run the user info form
                        break;
                }


            }

        }
    }
}