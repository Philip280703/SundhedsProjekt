using Sundhed.Bmi.Application.Repositories;
using Sundhed.BMI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sundhed.Bmi.Application.Command.Implementation
{
    public class CreateBmiCommand : ICreateBmiCommand
    {
        private readonly IBmiRepository _bmiRepository;
        public CreateBmiCommand(IBmiRepository bmiRepository)
        {
            _bmiRepository = bmiRepository;
        }
        void ICreateBmiCommand.Create(BmiCreateRequestDto bmiCreateRequestDto)
        {
            var id = _bmiRepository.GetNextKey();
            var bmi = new BmiEntity(bmiCreateRequestDto.Height, bmiCreateRequestDto.Weight, id);
            _bmiRepository.Add(bmi);
        }
    }
}
