using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII
{
    public class State
    {



        private byte state; // i create a variable with the byte type this is due to because it will need less storage than an int variable due to its smaller size,
                            // either way i could use an int but this way is more optimized, this byte variable is the one who will be changing when i change from one form to anotehr
                            // or when I exit the programm*/

        public State()
        {

            this.state = 2; // I initialized the variable to being 2, so the first thing that will open will be the login form
        }

        public void ChangeSate(byte state)
        {

            this.state = state; //this method is used to change the value of the state varible, i need to create this beacause it will be the method called in the forms to change the variable

        }
        public byte GetSate() // this method is used to get the value of the state variable, using a return this state
        {
            return this.state;
        }


    }
}
