using EnocaProject.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Business.ValidationRules
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty();
            RuleFor(x => x.FinishHour).NotEmpty();
            RuleFor(x => x.StartHour).NotEmpty();
            RuleFor(x => x.CompanyApprovalStatus).NotEmpty();
        }
    }
}
