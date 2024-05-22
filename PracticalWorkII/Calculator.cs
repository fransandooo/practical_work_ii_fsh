using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII
{
    public class Calculator
    {
        private List<Operation> operations;

        public Calculator() //is all the same as given in the guided excersice, i just changed the return type of the method PerformOperation to string, because i want to return the result of the operation
            //Same happened with the other classes that are from the guided excersice, i keept them the same, i just changed some things, like taking out console.writeline and putting messagebox.show
        {
            this.operations = new List<Operation>();

            this.operations.Add(new Add("Add", " + "));
            this.operations.Add(new Subtract("Subtract", " - "));
            this.operations.Add(new Divide("Divide", " / "));
            this.operations.Add(new Multiply("Multiply", " * "));
            this.operations.Add(new Pow("Pow", "^"));
            this.operations.Add(new Modulus("Modulus", " % "));
        }

        public int Exit()
        {
            return this.operations.Count + 1;
        }
        private int GetOperationBySign(string sign)
        {
            for (int i = 0; i < this.operations.Count; i++)
            {
                if (sign == this.operations[i].GetSymbol()) return i + 1;
            }

            return 0;
        }

        private string FixOperand(string operand)
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;

            if (currentCulture.TwoLetterISOLanguageName == "es")
            {
                operand = operand.Replace(".", ",");
            }
            else
            {
                operand = operand.Replace(",", ".");
            }

            return operand;
        }

        private Boolean IsDecimalOperation(string op1, string op2)
        {
            ArrayList operators = new ArrayList(2);

            bool DecimalOp = false;

            if (op1.Contains(".") || op2.Contains(".")) DecimalOp = true;
            if (op1.Contains(",") || op2.Contains(",")) DecimalOp = true;

            return DecimalOp;
        }

        public string PerformOperation(string operation)
        {
            string[] components = operation.Split(" ");

            int op = this.GetOperationBySign(components[1]);

            if (op != 0)
            {
                this.PerformOperation(
                    op,
                    components[0],
                    components[2]);
            }

            return PerformOperation(op, components[0], components[2]);
        }

        public string PerformOperation(int op, string op1, string op2)// i changed the return type of the method to string, because i want to return the result of the operation
        {
            Result result = null;

            try
            {

                op1 = FixOperand(op1);
                op2 = FixOperand(op2);

                if (IsDecimalOperation(op1, op2))
                {
                    result = this.operations[op - 1].Operate(
                        Double.Parse(op1),
                        Double.Parse(op2));
                }
                else
                {
                    result = this.operations[op - 1].Operate(
                        Int32.Parse(op1),
                        Int32.Parse(op2));
                }

                if(result == null)
                {
                    MessageBox.Show("This operation cannot be performed.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("This operation cannot be performed.");
            }

            return result.GetValue().ToString();//return the result of the operation


        }
    }
}