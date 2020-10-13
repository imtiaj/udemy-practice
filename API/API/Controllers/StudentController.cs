using DLL.Models;
using DLL.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{    
    public class StudentController: ApiBaseController
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository StudentRepository)
        {
            studentRepository = StudentRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await studentRepository.GetAllStudentAsync());
        }

        [HttpGet]
        [Route("{email}")]
        public async Task<ActionResult> GetAStudent(string email)
        {
            return Ok(await studentRepository.GetAStudentAsync(email));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(Student aStudent)
        {
            return Ok(await studentRepository.AddStudentAsync(aStudent));
        }
        
        //[HttpPut("{email}")]
        //public ActionResult Update(string email,Student aStudent)
        //{
        //    return Ok(AllStudentInfo.UpdateStudent(email,aStudent));
        //}

        //[HttpDelete("{email}")]
        //public ActionResult Delete(string email)
        //{
        //    return Ok(AllStudentInfo.DeleteStudent(email));
        //}
    }
}
