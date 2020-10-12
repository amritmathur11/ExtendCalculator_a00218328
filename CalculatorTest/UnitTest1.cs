using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultiplyOnePostiveAndOneNegativeNumberMethod()
  
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            string c = "M";
            double q = 6;
            double r = -2;
            double awnser = q * r;
            double methodReturn = calculator.DoOperation(q, r, c);
            Assert.AreEqual(awnser, methodReturn);
        }
        [TestMethod]
        public void AddTwoPostiveNumbersMethod()

        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            string c = "A";
            double q = 2;
            double r = 4;
            double awnser = q + r;
            double methodReturn = calculator.DoOperation(q, r, c);
            Assert.AreEqual(awnser, methodReturn);
        }
        [TestMethod]
        public void AddTwoNegativeNumberMethod()

        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            string c = "A";
            double q = -2;
            double r = -3;
            double awnser = q + r;
            double methodReturn = calculator.DoOperation(q, r, c);
            Assert.AreEqual(awnser, methodReturn);
        }
        [TestMethod]
        public void AddOnePostiveAndNegativeNumberMethod()

        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            string c = "A";
            double q = 4.5;
            double r = -4;
            double awnser = q + r;
            double methodReturn = calculator.DoOperation(q, r, c);
            Assert.AreEqual(awnser, methodReturn);
        }
        [TestMethod]
        public void SubtractTwoPostiveNumberMethod()

        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            string c = "S";
            double q = 6.5;
            double r = 2;
            double awnser = q - r;
            double methodReturn = calculator.DoOperation(q, r, c);
            Assert.AreEqual(awnser, methodReturn);
        }
        [TestMethod]
        public void DivideTwoPostiveNumberMethod()

        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            string c = "D";
            double q = 9;
            double r = 2;
            double awnser = q / r;
            double methodReturn = calculator.DoOperation(q, r, c);
            Assert.AreEqual(awnser, methodReturn);
        }
        [TestMethod]
        public void MultiplyTwoPostiveNumbersMethod()

        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            string c = "M";
            double q = 7.7;
            double r = 3;
            double awnser = q * r;
            double methodReturn = calculator.DoOperation(q, r, c);
            Assert.AreEqual(awnser, methodReturn);
        }
        [TestMethod]
        public void MultiplyTwoNegativeNumbersMethod()

        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            string c = "M";
            double q = -3;
            double r = -6;
            double awnser = q * r;
            double methodReturn = calculator.DoOperation(q, r, c);
            Assert.AreEqual(awnser, methodReturn);
        }
        [TestMethod]
        public void SubtractTwoNegativeNumbersMethod()

        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            string c = "S";
            double q = -8;
            double r = -6;
            double awnser = q - r;
            double methodReturn = calculator.DoOperation(q, r, c);
            Assert.AreEqual(awnser, methodReturn);
        }
        [TestMethod]
        public void SubtractOnePostiveAndOneNegativeNumberMethod()

        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            string c = "S";
            double q = 5.5;
            double r = -1;
            double awnser = q - r;
            double methodReturn = calculator.DoOperation(q, r, c);
            Assert.AreEqual(awnser, methodReturn);
        }
    }
}
