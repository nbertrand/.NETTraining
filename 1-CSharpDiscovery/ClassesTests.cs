using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    using System;

    [TestFixture]
    public class ClassesTests
    {
        [Test]
        public void CreateACalculatorClassWithADefaultConstructorAndInstanciate()
        {
            var calculator = new Calculator();
            Check.That(calculator).IsNotNull();
        }

        [Test]
        public void AddAnotherConstructorWithAFriendlyNameAndInstanciate()
        {
            // use a public member for Name for now, i.e public string Name;
            var calculator = new Calculator("Calculator");
            Check.That(calculator.Name).Equals("Calculator");
        }

        [Test]
        public void AddAMethodThatMakeASumOfAnArrayOfDouble()
        {
            var valuesToSum = new[] { 1.3, 1.7 };
            // add a method Sum to calculator class
            var sumOfTheArray = new Calculator().Sum(valuesToSum);
            Check.That(sumOfTheArray).Equals(3.0);
        }

        [Test]
        public void AddAMethodOverloadThatMakeASumOfTwoDoubleFromStringRepresentation()
        {
            var sumOfTwoDoubleFromString = "1,0+2";
            // add a method with the same name that uses the previous method
            // tips : use string.Split
            var onePlusTwo = new Calculator().Sum(sumOfTwoDoubleFromString);
            Check.That(onePlusTwo).Equals(3.0);
        }

        [Test]
        public void AddAGetterForNameInsteadOfPublicNameMember()
        {
            var calculator = new Calculator("Calculator");
            Check.That(calculator.Name).Equals("Calculator");
        }

        [Test]
        public void AddASetterForNameAndChangeNameWithIt()
        {
            var calculator = new Calculator("Calculator");
            calculator.Name = "Enhanced Calculator";
            Check.That(calculator.Name).Equals("Enhanced Calculator");
        }

        [Test]
        public void UseObjectInitilizerWithDefaultConstructor()
        {
            var calculator = new Calculator() { Name = "Calculator"};
            Check.That(calculator.Name).Equals("Calculator");
        }

        [Test]
        public void DefineConstantForPi()
        {
            var sumOfADoubleAndPiConstant = "1,2 + pi";
            // define pi constant (as double) and replace pi string with constant value
            var sum = new Calculator().Sum(sumOfADoubleAndPiConstant);
            Check.That(sum).Equals(4.34);
        }

        //[Test]
        //public void StaticReadonlyMembers()
        //{
        //    var sumOfADoubleAndPiConstant = "1,2 + pi";
        //    // replace pi constant with a static readonly member
        //    Check.That(sum).Equals(4.34);
        //}

        [Test]
        public void MakeSumMethodsStaticAsTheyDoNotNeedAnyInstanceSpecific()
        {
            // make sum methods static and call one these to retrieve a sum of double array values
            var valuesToSum = new[] { 1.3, 1.7 };
            var sum = Calculator.StaticSum(valuesToSum);
            Check.That(sum).Equals(3.0);
        }

        [Test]
        public void AddStaticCalculatorClass()
        {
            // define a static class StaticCalculator that uses Calculator static methods & define static getter for Name
            Check.That(StaticCalculator.Name).Equals("Static calculator");
        }
    }

    public static class StaticCalculator
    {
        public static string Name { get; set; }

        static StaticCalculator()
        {
            Name = "Static calculator";
        }
    }
}
