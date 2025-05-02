using FluentValidation;
using LeadManagement.Domain.Entities;

namespace LeadManagement.Infra.Data.EntitiesValidation
{
    public class LeadValidation : AbstractValidator<Lead>
    {
        public LeadValidation() 
        { 
            RuleFor(l => l.ContactFirstName).NotEmpty().WithMessage("FirstName Required")
                .Length(3,30).WithMessage("Minimum 3 and maximum 30 characters");
            RuleFor(l => l.ContactFullName).NotEmpty().WithMessage("FullName Required")
                .Length(5, 80).WithMessage("Minimum 5 and maximum 80 characters");
            RuleFor(l => l.ContactPhoneNumber).Length(11)
                .NotEmpty().WithMessage("PhoneNumber Required");
            RuleFor(l => l.ContactEmail).EmailAddress().WithMessage("Invalid E-mail");
            RuleFor(l => l.Suburb).NotEmpty().WithMessage("Suburb Required")
                .Length(3, 200).WithMessage("Minimum 3 and maximum 200 characters");
            RuleFor(l => l.Category).NotEmpty().WithMessage("Category Required")
                .Length(2, 50).WithMessage("Minimum 2 and maximum 50 characters");
            RuleFor(l => l.Price).NotEmpty().GreaterThan(0).WithMessage("Price must be greater than 0");
            RuleFor(l => l.Description).NotEmpty().WithMessage("Description Required")
                .Length(20, 150).WithMessage("Minimum 20 and maximum 150 characters");
            RuleFor(l => l.JobId).NotEmpty().WithMessage("JobId Required");
            RuleFor(l => l.Status).NotEmpty().WithMessage("Status Required");


        }
    }
}
