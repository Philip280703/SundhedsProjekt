using Sundhed.BMI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sundhed.BMI.Domain.Test.BmiEntityTest
{
    [TestFixture]
    public class BmiEntityCalculateBmiTest
    {

        [TestCase(200, 100, 25)]
        [TestCase(190, 90, 24.9)]
        public void Given_Height_And_Wieght_Then_Bmi_Is_Calculated_Corret(double height, double weight, double expected)
        {
            // Arrange
            var result = new BmiEntityTest(height, weight);

            // Act
            result.CalculateBmi();

            // Assert
            Assert.AreEqual(expected, Math.Round(result.Bmi,1));
        }



        /// <summary>
        /// Laver en class som arver fra bmientity for at gøre en protected metode synlig
        /// </summary>
        public class BmiEntityTest : BmiEntity
        {
            public BmiEntityTest(double height, double weight) : base(height, weight, 1)
            {
            }
            public new void CalculateBmi()
            {
                base.CalculateBmi();
            }
        }
    }

}
