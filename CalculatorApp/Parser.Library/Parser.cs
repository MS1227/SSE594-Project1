using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parser.Library
{
    public class Parser
    {
        public static object Operator(string inputOperator, object a, object b)
        {
            int iResult = 0;
            double dResult = 0;
            if (a.GetType() == typeof(double) || b.GetType() == typeof(double))
            {
                switch (inputOperator)
                {
                    case "+":
                        dResult = CalcFunctions.Library.CalcFunctions.Add(a, b);
                        break;
                    case "-":
                        dResult = CalcFunctions.Library.CalcFunctions.Subtract(a, b);
                        break;
                    case "*":
                        dResult = CalcFunctions.Library.CalcFunctions.Multiply(a, b);
                        break;
                    case "/":
                        dResult = CalcFunctions.Library.CalcFunctions.Divide(a, b);
                        break;
                    default:
                        break;

                }
                return dResult;
            }
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
