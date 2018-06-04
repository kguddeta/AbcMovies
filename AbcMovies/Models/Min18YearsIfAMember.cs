using System;
using System.ComponentModel.DataAnnotations;

namespace AbcMovies.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
            if(customer.MembershipTypeId == MembershipType.Unkown 
               || customer.MembershipTypeId ==MembershipType.PayAsYougo)
                return  ValidationResult.Success;
            if(customer.BirthDate==null)
                return  new ValidationResult("Birthdate is required");
            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years of age to be a membership. ");
        }
    }
}