﻿using Sundhed.BMI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sundhed.BMI.Domain.Test.BmiEntityTest
{
    [TestFixture]
    public class BmiEntityCreateTest
    {
        
        /// <summary>
        /// højde mellem 100 og 250 acceptabelt
        /// </summary>
        [TestCase(200)]
        [TestCase(250)]
        [TestCase(100)]
        public void Given_Height_Is_Valid_Then_BmiEntity_Is_Created(double height)
        {
            // Arrange

            // Act
            var result = new BmiEntity(height, 100);

            // Assert
        }

        /// <summary>
        /// Acceptable højde er 100 til 250, tester edge case
        /// </summary>
        /// <param name="height"></param>
        [TestCase(250.01)]
        [TestCase(99.99)]
        public void Given_Height_Is_InValid_Then_ArgumentException_is_Thrown(double height)
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => new BmiEntity(height, 100));
        }

        /// <summary>
        /// vægt mellem 40 og 250 acceptabelt
        /// </summary>
        [TestCase(100)]
        [TestCase(40)]
        [TestCase(250)]
        public void Given_Weight_Is_Valid_Then_BmiEntity_Is_Created(double weight)
        {
            // Arrange

            // Act
            var result = new BmiEntity(140, weight);

            // Assert
        }

        /// <summary>
        /// Acceptable vægt er 40 til 250, tester edge case
        /// </summary>
        /// <param name="height"></param>
        [TestCase(250.01)]
        [TestCase(39.99)]
        public void Given_Weight_Is_InValid_Then_ArgumentException_is_Thrown(double weight)
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => new BmiEntity(140, weight));
        }
    }
}