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
        public ActionResult GetAll()
        {
            return Ok(studentRepository.GetAllStudent());
        }

        [HttpGet]
        [Route("{email}")]
        public ActionResult GetAStudent(string email)
        {
            return Ok(studentRepository.GetAStudent(email));
        }

        [HttpPost]
        public ActionResult Insert(Student aStudent)
        {
            return Ok(studentRepository.AddStudent(aStudent));
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
