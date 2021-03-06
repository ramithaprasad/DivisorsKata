﻿using DivisorsKata;
using NUnit.Framework;

namespace DivisorKata.Tests.Unit
{
    [TestFixture]
    public class DivisorCalculatorTests
    {
        private DivisorCalculator _divisorCalculator;

        [OneTimeSetUp]
        public void GivenADivisorCalculator()
        {
            _divisorCalculator = new DivisorCalculator();
        }

        [TestCase(1, new[] {1})]
        [TestCase(2, new[] { 1, 2 })]
        [TestCase(4, new[] { 1, 2, 4 })]
        [TestCase(10,new[] {1,2,5,10})]
        public void WhenCalculateIsCalledThenTheExpectedResponseIsReturned(int inputNumber, int[] expectedResponse)
        {
            var response = _divisorCalculator.Calculate(inputNumber);
            Assert.That(response, Is.EqualTo(expectedResponse));
        }

    }
}
