using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parser.Library
{
    public class Parser
    {
        public static object parseString(string input)
        {
            string[] operands = input.Split(' ');
            string currOperater = string.Empty;

            bool containsDouble = false, isFirstArg = true;
            bool iArgAUsed = false, iArgBUsed = false, dArgAUsed = false, dArgBUsed = false;
            int iArgA = 0, iArgB = 0, iResult = 0;
            double dArgA = 0, dArgB = 0, dResult = 0;

            foreach (string x in operands)
            {
                //look for decimal in double values
                if (x.Contains("."))
                {
                    containsDouble = true;
                    if (isFirstArg)
                    {
                        Double.TryParse(x, out dArgA);
                        isFirstArg = false;
                        dArgAUsed = true;
                    }
                    else
                    {
                        Double.TryParse(x, out dArgB);
                        dArgBUsed = true;
                    }
                }
                //look for integers
                else if (x.Any(char.IsDigit))
                {

                    if (isFirstArg)
                    {
                        Int32.TryParse(x, out iArgA);
                        isFirstArg = false;
                        iArgAUsed = true;
                    }
                    else
                    {
                        Int32.TryParse(x, out iArgB);
                        iArgBUsed = true;
                    }

                }
                else
                {
                    currOperater = x;
                }

                if (iArgAUsed && iArgBUsed)
                {
                    iResult = (int) Operate(currOperater, iArgA, iArgB);
                    iArgAUsed = false;
                    iArgBUsed = false;
                    
                    
                }
                else if (iArgAUsed && dArgBUsed)
                {
                    dResult = (double) Operate(currOperater, iArgA, dArgB);
                    iArgAUsed = false;
                    dArgBUsed = false;
                    
                }
                else if(dArgAUsed && iArgBUsed)
                {
                    dResult = (double) Operate(currOperater, dArgA, iArgB);
                    dArgAUsed = false;
                    iArgBUsed = false;
                    
                }
                else if(dArgAUsed && dArgBUsed)
                {
                    dResult = (double) Operate(currOperater, dArgA, dArgB);
                    dArgAUsed = false;
                    dArgBUsed = false;
                }
                
            }
            if(containsDouble)
            {
                return dResult;
            }
            else
            {
                return iResult;
            }

        }
        public static object Operate(string inputOperator, object a, object b)
        {
            int iResult = 0;
            double dResult = 0;
            if (a.GetType() == typeof(double) || b.GetType() == typeof(double)
                || inputOperator == "/")
            {
                switch (inputOperator)
                {
                    case "+":
                        dResult = (double) CalcFunctions.Library.CalcFunctions.Add(a, b);
                        break;
                    case "-":
                        dResult = (double) CalcFunctions.Library.CalcFunctions.Subtract(a, b);
                        break;
                    case "*":
                        dResult = (double) CalcFunctions.Library.CalcFunctions.Multiply(a, b);
                        break;
                    case "/":
                        double argA = Convert.ToDouble(a);
                        double argB = Convert.ToDouble(b);
                        dResult = (double) CalcFunctions.Library.CalcFunctions.Divide(argA, argB);
                        break;
                    default:
                        break;

                }
                return dResult;
            }
            else
            {
                switch (inputOperator)
                {
                    case "+":
                        iResult = (int)CalcFunctions.Library.CalcFunctions.Add(a, b);
                        break;
                    case "-":
                        iResult = (int)CalcFunctions.Library.CalcFunctions.Subtract(a, b);
                        break;
                    case "*":
                        iResult = (int)CalcFunctions.Library.CalcFunctions.Multiply(a, b);
                        break;
                    default:
                        break;

                }
                return iResult;

            }
        }
        
    }
}
