using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Request
{
    public class EmployeeUpdateRequest
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string NationalID { get; set; }
        public string Email { get; set; }
    }

    public class EmployeeUpdateRequestValidator : AbstractValidator<EmployeeUpdateRequest>
    {
        public EmployeeUpdateRequestValidator()
        {
            _ = RuleFor(emp => emp.FirstName).NotEmpty().NotNull();
            _ = RuleFor(emp => emp.LastName).NotEmpty().NotNull();
            _ = RuleFor(emp => emp.DateOfBirth).NotEmpty().NotNull();
            _ = RuleFor(emp => emp.Gender).NotEmpty().NotNull();
            _ = RuleFor(emp => emp.NationalID).NotEmpty().NotNull();
            _ = RuleFor(emp => emp.Email).NotEmpty().NotNull();
        }
    }
}
