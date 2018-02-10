using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerUnitTest
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            string goalSteps = "5000", actualSteps = "2000";
            decimal expected = 40M;

            //Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
