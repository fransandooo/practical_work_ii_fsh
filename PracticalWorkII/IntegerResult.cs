using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII
{
    public class IntegerResult : Result
    {
        private int value;

        public IntegerResult(int value)
        {
            this.value = value;
        }

        public override Object GetValue()
        {
            return this.value;
        }
    }
}
