using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sundhed.Bmi.Application.Command
{
    public class BmiCreateRequestDto
    {
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
