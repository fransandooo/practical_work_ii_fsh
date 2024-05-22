using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII
{
    public class DoubleResult : Result
    {
        private double value;

        public DoubleResult(double value)
        {
            this.value = value;
        }

        public override Object GetValue()
        {
            return this.value;
        }
    }
}
