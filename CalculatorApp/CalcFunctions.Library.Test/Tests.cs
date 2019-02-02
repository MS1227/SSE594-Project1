using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFunctions.Library.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CalcFunctions_add_Two_Numbers()
        {
            //Arrange
            int a = 1, b = 2;

            //Act
            int result = (int) CalcFunctions.Add(a, b);
            //Assert
            Assert.AreEqual(result, a + b);
        }
        [Test]
        public void CalcFunctions_Subtract_Two_Numbers()
        {

            int a = 1, b = 2;

            int result = (int)CalcFunctions.Subtract(b, a);

            Assert.AreEqual(result, b - a);
        }
        [Test]
        public void CalcFunctions_Multiply_Two_Numbers()
        {
            int a = 2, b = 3;

            int result = (int)CalcFunctions.Multiply(a, b);

            Assert.AreEqual(result, a * b);
        }
        
        [Test]
        public void CalcFunctions_Divide_Two_Double_Numbers()
        {
            double a = 2.393, b = 4.9393;

            double result = (double) CalcFunctions.Divide(a, b);

            Assert.AreEqual(result, a / b);
        }
        [Test]
        public void CalcFunctions_Add_Two_Double_Numbers()
        {
            double a = 2.393, b = 4.9393;

            double result = (double) CalcFunctions.Add(a, b);

            Assert.AreEqual(result, a + b);
        }
        [Test]
        public void CalcFunctions_Subtract_Two_Double_Numbers()
        {
            double a = 2.393, b = 4.9393;

            double result = (double)CalcFunctions.Subtract(a, b);

            Assert.AreEqual(result, a - b);
        }
        [Test]
        public void CalcFunctions_Multiply_Two_Double_Numbers()
        {
            double a = 2.393, b = 4.9393;

            double result = (double)CalcFunctions.Multiply(a, b);

            Assert.AreEqual(result, a * b);
        }
        [Test]
        public void CalcFunctions_Add_Int_And_Double_Numbers()
        {
            double a = 32.32232;
            int b = 5;

            double result = (double)CalcFunctions.Add(a, b);
            Assert.AreEqual(result, a + b);
        }
        [Test]
        public void CalcFunctions_Subtract_Int_And_Double_Numbers()
        {
            double a = 12.392;
            int b = 5;

            double result = (double)CalcFunctions.Subtract(a, b);
            Assert.AreEqual(result, a - b);
        }
        [Test]
        public void CalcFunctions_Multiply_Int_And_Double_Numbers()
        {
            double a = 2.3939;
            int b = 9;

            double result = (double)CalcFunctions.Multiply(a, b);
            Assert.AreEqual(result, a * b);
        }
        [Test]
        public void CalcFunctions_Divide_Int_Double_Numbers()
        {
            double a = 9.32314;
            int b = 3;

            double result = (double)CalcFunctions.Divide(a, b);
            Assert.AreEqual(result, a / b);
        }
        [Test]
        public void Check_For_Integer_Overflow_Add()
        {
            int a = Int32.MaxValue;
            int b = 1;

            object result = CalcFunctions.Add(a, b);
            Assert.AreEqual(result.ToString(), "OVERFLOW");
        }
        [Test]
        public void Check_For_Integer_Underflow_Sub()
        {
            int a = Int32.MinValue;
            int b = 1;

            object result = CalcFunctions.Subtract(a, b);
            Assert.AreEqual(result.ToString(), "UNDERFLOW");

        }
    }
}
