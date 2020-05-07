using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class Math_Lab1Tests
    {
        //Var 2
        [TestMethod]
        public void AlessThanB_ReturnsTrue()
        {
            //Arrange 
            var Math_lab1 = new Math_Lab1();

            //Act
            var result = Math_lab1.AlessThanB(1, 7);

            //Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AlessThanB_ReturnsFalse()
        {
            //Arrange
            var Math_lab1 = new Math_Lab1();

            //Act
            var result = Math_lab1.AlessThanB(9, 7);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
