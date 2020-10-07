using BLL.Request;
using BLL.Services;
using DLL.Models;
using DLL.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{    
    public class EmployeeController : ApiBaseController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            return Ok(await _employeeService.GetAllEmployeeAsync());
        }

        [HttpGet]
        [Route("{email}")]
        public async Task<IActionResult> GetAEmployee(string email)
        {
            return Ok(await _employeeService.GetAEmployeeAsync(email));
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeAddRequest employeeInfo)
        {
            return Ok(await _employeeService.AddEmployeeInfoAsync(employeeInfo));
        }
<<<<<<< HEAD

        //[HttpPut("{email}")]
        //public async Task<ActionResult> UpdateEmployee(string email, EmployeeUpdateRequest updateRequest)
        //{
        //    return Ok(await _employeeService.UpdateEmployeeAsync(email, updateRequest));
        //}

        [HttpDelete("{email}")]
        public async Task<ActionResult> DeleteEmployeeBasicProfile(string email)
        {
            return Ok(await _employeeService.DeleteEmployee(email));
        }
=======
        
>>>>>>> 772da065a6a917639f0162ff4bf7caef8159f0f9
    }
}
