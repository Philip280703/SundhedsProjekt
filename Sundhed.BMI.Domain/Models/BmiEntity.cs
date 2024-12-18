using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sundhed.BMI.Domain.Models
{
    public class BmiEntity
    {
        public double Height { get; private set; }
        public double Weight { get; private set; }
        public double Bmi { get; private set; }

        public BmiEntity(double height, double weight) 
        {

            // check pre-condition
            this.Height = height;
            this.Weight = weight;

            if (!isValid())
            {
                throw new ArgumentException("Pre-condition er ikke overholdt");
            }

            //logic
            var bmi = weight / (height * height);

            //post-condition
            Bmi = bmi;

        }

        /// <summary>
        /// acceptable højde er 100 til 250
        /// vægt er 40 til 250
        /// </summary>
        /// <returns></returns>
        protected bool isValid()
        {
            if(Height < 100) return false;
            if(Height > 250) return false;
            if(Weight < 40) return false;
            if(Weight > 250) return false;

            return true;
        }
    }
}
