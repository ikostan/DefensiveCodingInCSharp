﻿using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
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

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            //Arrange
            Customer customer = new Customer();
            string goalSteps = "5000", actualSteps = "5000";
            decimal expected = 100M;

            //Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            //Arrange
            Customer customer = new Customer();
            string goalSteps = "5000", actualSteps = "0";
            decimal expected = 0M;

            //Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNull()
        {
            // Arrange
            Customer customer = new Customer();
            string goalSteps = null, actualSteps = "2000";

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            // Done automaticaly by ExpectedException attribute
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNotNumeric()
        {
            // Arrange
            Customer customer = new Customer();
            string goalSteps = "one", actualSteps = "2000";

            // Act
            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Goal must be numeric", ex.Message);
                throw;
            }           
        }
    }
}
