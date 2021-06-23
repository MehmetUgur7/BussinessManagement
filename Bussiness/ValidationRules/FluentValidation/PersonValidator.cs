using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PersonValidator:AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.RegistrationNumber).NotEmpty();
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
