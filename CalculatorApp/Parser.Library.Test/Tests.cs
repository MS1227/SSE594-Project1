using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Parser.Library.Test
{
    public class Tests
    {
        [Test]
        public void Performs_Addition_When_Read_Plus()
        {
            int a = 3, b = 4;
            double c = 3.9292, d = 19.3393;

            int result = Parser.Operator("+",a,b);
            double dResult = Parser.Operator("+", c, d);

            Assert.AreEqual(result, a + b);
            Assert.AreEqual(dResult, c + d);
        }
        [Test]
        public void Performs_Subtraction_When_Read_Minus()
        {
            int a = 10, b = 5;
            double c = 13.2930, d = 9.892;

            int result = Parser.Operator("-", a, b);
            double dResult = Parser.Operator("-", c, d);

            Assert.AreEqual(result, a - b);
            Assert.AreEqual(dResult, c - d);
        }
        [Test]
        public void Performs_Mult_When_Read_Asterisk()
        {
            int a = 10, b = 12;
            double c = 13.3222, d = 19.3333;

            int result = Parser.Operator("*", a, b);
            double dResult = Parser.Operator("*", c, d);
        
            Assert.AreEqual(result, a * b);
            Assert.AreEqual(dResult, c * d);
        }
        [Test]
        public void Performs_Div_When_Read_Slash()
        {
            int a = 14, b = 7;
            double c = 13.3332, d = 3.2390;

            int result = Parser.Operator("/", a , b);
            double dResult = Parser.Operator("/", c, d);

            Assert.AreEqual(result, a / b);
            Assert.AreEqual(dResult, c / d);
        }
    }
}
