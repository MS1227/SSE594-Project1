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
            int result = CalcFunctions.Add(a, b);
            //Assert
            Assert.AreEqual(result, a + b);
        }
        [Test]
        public void CalcFunctions_Subtract_Two_Numbers()
        {

            int a = 1, b = 2;

            int result = CalcFunctions.Subtract(b, a);

            Assert.AreEqual(result, b - a);
        }
        [Test]
        public void CalcFunctions_Multiply_Two_Numbers()
        {
            int a = 2, b = 3;

            int result = CalcFunctions.Multiply(a, b);

            Assert.AreEqual(result, a * b);
        }
        [Test]
        public void CalcFunctions_Divide_Two_Int_Numbers()
        {
            int a = 4, b = 2;

            int result = CalcFunctions.Divide(a, b);

            Assert.AreEqual(result, a / b); 
        }
        [Test]
        public void CalcFunctions_Divide_Two_Double_Numbers()
        {
            double a = 2.393, b = 4.9393;

            double result = CalcFunctions.Divide(a, b);

            Assert.AreEqual(result, a / b);
        }
        [Test]
        public void CalcFunctions_Add_Two_Double_Numbers()
        {
            double a = 2.393, b = 4.9393;

            double result = CalcFunctions.Add(a, b);

            Assert.AreEqual(result, a + b);
        }
        [Test]
        public void CalcFunctions_Subtract_Two_Double_Numbers()
        {
            double a = 2.393, b = 4.9393;

            double result = CalcFunctions.Subtract(a, b);

            Assert.AreEqual(result, a - b);
        }
        [Test]
        public void CalcFunctions_Multiply_Two_Double_Numbers()
        {
            double a = 2.393, b = 4.9393;

            double result = CalcFunctions.Multiply(a, b);

            Assert.AreEqual(result, a * b);
        }
    }
}
