using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation_Rules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cu => cu.Id).NotEmpty();
            RuleFor(cu => cu.CompanyName).MinimumLength(2);

        }
    }
}
