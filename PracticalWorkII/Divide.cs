using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII
{
    public class Divide : Operation
    {
        public Divide(string name, string symbol) : base(name, symbol)
        {
        }

        public override Result Operate(int op1, int op2)
        {
            try
            {
                return new DoubleResult(op1 / op2);
            }
            catch (DivideByZeroException)
            {
                return new IntegerResult(Int32.MaxValue);
            }
        }
        public override Result Operate(double op1, double op2)
        {
            if (op2 == 0)
                return new DoubleResult(Double.MaxValue);
            else
                return new DoubleResult(op1 / op2);
        }
    }
}
