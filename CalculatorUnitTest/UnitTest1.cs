using System;
using NUnit.Framework;

namespace CalculatorGroup20
{
    public class Tests
    {
        //ARRANGE
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator=new Calculator();
        }

        //ADD METHOD TEST
        [Test]
        public void TestAddMethod()
        {
            //ACT og ASSERT
            Assert.That(_calculator.Add(4, 2), Is.EqualTo(6));
        }

        [Test]
        public void TestAddMethod4and4_Returns8()
        {
            //ACT og ASSERT
            Assert.That(_calculator.Add(4, 4), Is.EqualTo(8));
        }

        [Test]
        public void TestAddMethodMinusOne()
        {
            Assert.That(_calculator.Add(4, -1), Is.EqualTo(3));
        }

        [Test]
        public void TestAddMethodMinusTwo()
        {
            Assert.That(_calculator.Add(-4, -1), Is.EqualTo(-5));
        }

        //SUBTRACT METHOD TEST
        [Test]
        public void TestSubtractMethod()
        {
            Assert.That(_calculator.Subtract(3, 2), Is.EqualTo(1));
        }

        [Test]
        public void TestSubtractMethodMinusOne()
        {
            Assert.That(_calculator.Subtract(3, -2), Is.EqualTo(5));
        }

        [Test]
        public void TestSubtractMethodMinusTwo()
        {
            Assert.That(_calculator.Subtract(-3, -2), Is.EqualTo(-1));
        }

        //MULTIPLY METHOD TEST
        [Test]
        public void TestMultiplyMethod()
        {
            double a = 2;
            double b = 2;
            //ACT
            double resulat = _calculator.Multiply(a, b);

            //ASSERT
            Assert.That(resulat, Is.EqualTo(4));
        }

        [Test]
        public void TestMultiplyMethodMinusOne()
        {
            double resulat = _calculator.Multiply(2, -2);
            Assert.That(resulat, Is.EqualTo(-4));
        }

        [Test]
        public void TestMultiplyMethodMinusTwo()
        {
            double resulat = _calculator.Multiply(-2, -2);
            Assert.That(resulat, Is.EqualTo(4));
        }

        //POWER METHOD TEST
        [Test]
        public void TestPowerMethod()
        {
            double a = 2;
            double b = 2;
            double resulat = _calculator.Power(a, b);
            Assert.That(resulat, Is.EqualTo(4));
        }
       
        [Test]
        public void TestPowerMethodMinusOne()
        {          
            double resulat = _calculator.Power(-2, 2);
            Assert.That(resulat, Is.EqualTo(4));
        }

        [Test]
        public void TestPowerMethodMinusTwo()
        {
            double resulat = _calculator.Power(-2, -2);
            Assert.That(resulat, Is.EqualTo(0.25));
        }

        //DIVIDE METHOD TEST
        [Test]
        public void TestDivideMethod()
        {
            Assert.That(_calculator.Divide(4,2), Is.EqualTo(2));
        }

        [Test]
        public void TestDivideMethodMinusUpper()
        {
            Assert.That(_calculator.Divide(-4, 2), Is.EqualTo(-2));
        }

        [Test]
        public void TestDivideMethodMinusLower()
        {
            Assert.That(_calculator.Divide(4, -2), Is.EqualTo(-2));
        }

        [Test]
        public void TestDivideMethodMinusBothLowerAndUpper()
        {
            Assert.That(_calculator.Divide(-4, -2), Is.EqualTo(2));
        }
        [Test]
        public void TestDivideMethodZero()
        {

            Assert.Throws<DivideByZeroException>(new TestDelegate((() => _calculator.Divide(4, int.Parse("0")))));
        }

        //ACCUMULATOR PROP TEST
        [Test]
        public void TestAccumulatorPropAdd()
        {
            Assert.That(_calculator.Add(2, 2), Is.EqualTo(_calculator.Accumulator));
        }

        [Test]
        public void TestAccumulatorPropSub()
        {
            Assert.That(_calculator.Subtract(3, 2), Is.EqualTo(_calculator.Accumulator));
        }
        [Test]
        public void TestAccumulatorPropMultipy()
        {
            Assert.That(_calculator.Multiply(3, 2), Is.EqualTo(_calculator.Accumulator));
        }
        [Test]
        public void TestAccumulatorPropPower()
        {
            Assert.That(_calculator.Power(3, 2), Is.EqualTo(_calculator.Accumulator));
        }
        [Test]
        public void TestAccumulatorPropDivide()
        {
            Assert.That(_calculator.Divide(3, 2), Is.EqualTo(_calculator.Accumulator));
        }

        //CLEAR METHOD TEST
        [Test]
        public void TestClearMethodAdd()
        {
            _calculator.Add(2, 2); //Skal kaldes for at der ligger en værdi i Accumulator.
            _calculator.Clear();
            double number =_calculator.Accumulator;
            Assert.That(number, Is.EqualTo(0));
        }

        [Test]
        public void TestClearMethodSub()
        {
            _calculator.Subtract(4, 2);
            _calculator.Clear();
            double number = _calculator.Accumulator;
            Assert.That(number, Is.EqualTo(0));
        }

        [Test]
        public void TestClearMethodPower()
        {
            _calculator.Power(4, 2);
            _calculator.Clear();
            double number = _calculator.Accumulator;
            Assert.That(number, Is.EqualTo(0));
        }

    }
}