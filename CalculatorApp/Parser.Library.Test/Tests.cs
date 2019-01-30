using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Parser.Library.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Performs_Addition_When_Read_Plus()
        {
            int a = 3, b = 4;
            double c = 3.9292, d = 19.3393;

            int result = (int) Parser.Operate("+",a,b);
            double dResult = (double) Parser.Operate("+", c, d);

            Assert.AreEqual(result, a + b);
            Assert.AreEqual(dResult, c + d);
        }
        [Test]
        public void Performs_Subtraction_When_Read_Minus()
        {
            int a = 10, b = 5;
            double c = 13.2930, d = 9.892;

            int result = (int) Parser.Operate("-", a, b);
            double dResult = (double) Parser.Operate("-", c, d);

            Assert.AreEqual(result, a - b);
            Assert.AreEqual(dResult, c - d);
        }
        [Test]
        public void Performs_Mult_When_Read_Asterisk()
        {
            int a = 10, b = 12;
            double c = 13.3222, d = 19.3333;

            int result = (int) Parser.Operate("*", a, b);
            double dResult = (double) Parser.Operate("*", c, d);
        
            Assert.AreEqual(result, a * b);
            Assert.AreEqual(dResult, c * d);
        }
        [Test]
        public void Performs_Div_When_Read_Slash()
        {
            int a = 14, b = 7;
            double c = 13.3332, d = 3.2390;
            

            double result = (double) Parser.Operate("/", a , b);
            double dResult = (double) Parser.Operate("/", c, d);

            Assert.AreEqual(result, a / b);
            Assert.AreEqual(dResult, c / d);
        }
        [Test]
        public void Parses_Addition_Int_String()
        {
            int result = (int) Parser.parseString("2 + 2");
            Assert.AreEqual(result, 4);
        }
        [Test]
        public void Parsed_Addition_Int_Double_String()
        {
            double result = Convert.ToDouble(Parser.parseString("2.2 + 2"));
            Assert.AreEqual(result, 4.2);
        }
        [Test]
        public void Parsed_Subtraction_Int_String()
        {
            int result = (int)Parser.parseString("5 - 2");
            Assert.AreEqual(result, 5 - 2);
        }
        [Test]
        public void Parsed_Subtraction_Mixed_Mode_String()
        {
            double result = Convert.ToDouble(Parser.parseString("5.780 - 3"));
            Assert.AreEqual(result, 5.780 - 3);
        }
        [Test]
        public void Parse_Multiplication_Int_String()
        {
            int result = (int)Parser.parseString("10 * 20");
            Assert.AreEqual(result, 10 * 20);
        }
        [Test]
        public void Parse_Multiplication_Mixed_Mode_String()
        {
            double result = Convert.ToDouble(Parser.parseString("10.393 * 20"));
            Assert.AreEqual(result, 10.393 * 20);
        }
        [Test]
        public void Parse_Division_Int_String()
        {
            double result = Convert.ToDouble(Parser.parseString("10 / 7"));
            Assert.AreEqual(result, (double)10 / (double)7);
        }
        [Test]
        public void Parse_Division_Mixed_Mode_String()
        {
            double result = Convert.ToDouble(Parser.parseString("10.35 / 2"));
            Assert.AreEqual(result, (double)10.35 / (double)2);
        }
    }
}
