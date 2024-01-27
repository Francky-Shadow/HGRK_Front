using FluentValidation;
using hgrkapp.DTO;
using System;

namespace hgrkapp.Validations
{
    public class StageValidation:AbstractValidator<stage>
    {
        public StageValidation() 
        {
            RuleFor(vm => vm.EtatStage)
              .NotEmpty()
              .MaximumLength(30);

            RuleFor(vm => vm.IdUniversite)
           .NotEmpty();
        }
        
    }
    //public class PersonValidator : AbstractValidator<Person>
    //{
    //    public PersonValidator()
    //    {
    //        RuleFor(vm => vm.FirstName)
    //            .NotEmpty()
    //            .MaximumLength(30);

    //        RuleFor(vm => vm.LastName)
    //            .NotEmpty()
    //            .MaximumLength(30);

    //        RuleFor(vm => vm.Age)
    //            .GreaterThanOrEqualTo(18);
    //    }
    //}
}
