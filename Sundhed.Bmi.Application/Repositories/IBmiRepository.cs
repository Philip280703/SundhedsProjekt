using Sundhed.BMI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sundhed.Bmi.Application.Repositories
{
    public interface IBmiRepository
    {
        void Add(BmiEntity bmi);
        int GetNextKey();
    }
}
