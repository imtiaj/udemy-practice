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
        private readonly IEmployeeInfoRepository _employeeInfoRepository;

        public EmployeeController(IEmployeeInfoRepository employeeInfoRepository)
        {
            _employeeInfoRepository = employeeInfoRepository;
        }

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            return Ok(_employeeInfoRepository.GetAllEmployee());
        }

        [HttpGet]
        [Route("{email}")]
        public IActionResult GetAEmployee(string email)
        {
            return Ok(_employeeInfoRepository.GetAEmployee(email));
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeInfo employeeInfo)
        {
            return Ok(_employeeInfoRepository.AddEmployeeInfo(employeeInfo));
        }
    }
}
