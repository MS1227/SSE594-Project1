using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFunctions.Library
{
    public class CalcFunctions
    {
       
        public static object Add(object a, object b)
        {
            double dResult = 0;
            int iResult = 0;
            if (a.GetType() == typeof(double) || b.GetType() == typeof(double))
            {
                dResult = (double)a + (double)b;

                return dResult;
            }
            else
            {
                iResult = (int)a + (int)b;

                return iResult;
            }
        }
        public static object Subtract(object a, object b)
        {
            double dResult = 0;
            int iResult = 0;
            if (a.GetType() == typeof(double) || b.GetType() == typeof(double))
            {
                dResult = (double)a - (double)b;
                return dResult;
            }
            else
            {
                iResult = (int)a - (int)b;
                return iResult;
            }
        }
        public static object Multiply(object a, object b)
        {
            double dResult = 0;
            int iResult = 0;
            if(a.GetType() == typeof(double) || b.GetType() == typeof(double))
            {
                dResult = (double)a * (double)b;
                return dResult;
            }
            else
            {
                iResult = (int)a * (int)b;
                return iResult;
            }
        }

        public static object Divide(object a, object b)
        {
            double dResult = 0;
            
            dResult = (double)a / (double)b;

            return dResult;
        }
        
    }
}
