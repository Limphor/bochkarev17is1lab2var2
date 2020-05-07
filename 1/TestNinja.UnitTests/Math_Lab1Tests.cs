using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //Var 2
    [TestFixture]
    public class Math_Lab1Tests
    {
        private Math_Lab1 _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab1();
        }
        [Test]
        [TestCase(5,7,true)]
        [TestCase(7,5,false)]
        [TestCase(5,5, true)]
        //декоратор для того, чтобы тест "завалился"
        [TestCase(5,7,false)]
        public void AlessThanB_WhenCalled_ReturnsBool(int a, int b, bool expectedResult)
        {
            var result = _math.AlessThanB(a,b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
