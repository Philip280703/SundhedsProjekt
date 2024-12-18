using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sundhed.BMI.Domain.Models
{
    public class BmiEntity
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Bmi { get; set; }
    }
}
