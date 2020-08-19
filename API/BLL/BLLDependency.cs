using BLL.Request;
using BLL.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class BLLDependency
    {
        public static void ALLDependency(IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IValidator<EmployeeAddRequest>, EmployeeAddRequestValidator>();
        }
    }
}
