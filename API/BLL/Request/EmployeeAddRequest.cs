using BLL.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Request
{
    public class EmployeeAddRequest
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string NationalID { get; set; }
        public string Email { get; set; }
    }

    public class EmployeeAddRequestValidator : AbstractValidator<EmployeeAddRequest>
    {
        private readonly IServiceProvider serviceProvider;

        public EmployeeAddRequestValidator(IServiceProvider serviceProvider)
        {
            RuleFor(x => x.EmployeeID).NotNull();
            RuleFor(x => x.FirstName).Length(0, 30).NotNull();
            RuleFor(x => x.LastName).Length(0, 30).NotNull();
            // RuleFor(x => x.DateOfBirth).NotNull();
            RuleFor(x => x.Email).EmailAddress().NotNull().NotEmpty().MustAsync(IsEmailExist).WithMessage("Email already exist");
            // RuleFor(x => x.Gender).NotNull();
            RuleFor(x => x.NationalID).NotNull().NotEmpty().MustAsync(IsNIDExist).WithMessage("NID Already exist");
            this.serviceProvider = serviceProvider;
        }

        private async Task<bool> IsNIDExist(string NationalID, CancellationToken arg2)
        {
            if (string.IsNullOrWhiteSpace(NationalID))
            {
                return true;
            }

            var empService = serviceProvider.GetRequiredService<IEmployeeService>();
            return await empService.IsNIDExist(NationalID);
        }

        private async Task<bool> IsEmailExist(string Email, CancellationToken arg2)
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                return true;
            }

            var empService = serviceProvider.GetRequiredService<IEmployeeService>();
            return await empService.IsEmailExist(Email);
        }
    }
}
