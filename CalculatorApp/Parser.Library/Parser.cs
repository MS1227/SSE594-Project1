﻿using System;
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
                        dResult = (double) CalcFunctions.Library.CalcFunctions.Divide(a, b);
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
