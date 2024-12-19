using Sundhed.Bmi.Application.Command.Repositories;
using Sundhed.BMI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sundhed.Bmi.Infrastructor.Rpositories
{
    public class BmiRepository : IBmiRepository
    {
        private Dictionary<int, BmiEntity> _database = new();
        void IBmiRepository.Add(Sundhed.BMI.Domain.Models.BmiEntity bmi) 
        {
            _database.Add(bmi.Id, bmi);
        }
        int IBmiRepository.GetNextKey() 
        {
            if (_database.Keys.Any()) 
            {
                return 1;
            }
            return _database.Keys.Max() + 1;
        }
    }
}
