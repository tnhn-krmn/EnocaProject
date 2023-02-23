using EnocaProject.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaProject.Business.ValidationRules
{
    public class OrderValidator : AbstractValidator<Order>
    {
    public OrderValidator()
    {
        RuleFor(x => x.OrdererName).NotEmpty();
        RuleFor(x => x.ProductId).GreaterThan(0);
        RuleFor(x => x.CompanyId).GreaterThan(0);

        }
    }
}

