using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class Math_Lab2Tests
    {
        private Math_Lab2 _math;

        [SetUp]
        public void SetUp ()
        {
            _math = new Math_Lab2();
        }
        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        //исправлены декораторы
        [TestCase(2, 1, 3)]
        [TestCase(1, 2, 3)]
        [TestCase(1, 1, 2)]
        //заведомо неправильные значения
        [TestCase(3,2,6)]
        //исправлен метод
        public void Add_WhenCalled_ReturnTheSumOfArguments(int a, int b, int expectedResult)    
        {
            var result = _math.Add(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.Not.Empty);

            Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Does.Contain(1));

            Assert.That(result, Does.Contain(3));

            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered);

            Assert.That(result, Is.Unique);
        }
    }
}
