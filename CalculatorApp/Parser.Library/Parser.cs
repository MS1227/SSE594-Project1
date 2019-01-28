using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parser.Library
{
    public class Parser
    {
       public static int Operator(string inputOperator, int a , int b)
        {
            int result = 0;
            switch(inputOperator)
            {
                case "+":
                    result = CalcFunctions.Library.CalcFunctions.Add(a, b);
                    break;
                case "-":
                    result = CalcFunctions.Library.CalcFunctions.Subtract(a, b);
                    break;
                case "*":
                    result = CalcFunctions.Library.CalcFunctions.Multiply(a, b);
                    break;
                case "/":
                    result = CalcFunctions.Library.CalcFunctions.Divide(a, b);
                    break;
                default:
                    break;

            }
            return result;
        }
        public static double Operator(string inputOperator, double a, double b)
        {
            double result = 0;
            switch (inputOperator)
            {
                case "+":
                    result = CalcFunctions.Library.CalcFunctions.Add(a, b);
                    break;
                case "-":
                    result = CalcFunctions.Library.CalcFunctions.Subtract(a, b);
                    break;
                case "*":
                    result = CalcFunctions.Library.CalcFunctions.Multiply(a, b);
                    break;
                case "/":
                    result = CalcFunctions.Library.CalcFunctions.Divide(a, b);
                    break;
                default:
                    break;

            }
            return result;
        }
    }
}
