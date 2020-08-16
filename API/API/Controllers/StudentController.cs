using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController: ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(AllStudentInfo.GetStudents());
        }

        [HttpGet]
        [Route("{email}")]
        public ActionResult GetAStudent(string email)
        {
            return Ok(AllStudentInfo.GetAStudent(email));
        }

        [HttpPost]
        public ActionResult Insert(Student aStudent)
        {
            return Ok(AllStudentInfo.AddStudent(aStudent));
        }
        
        [HttpPut("{email}")]
        public ActionResult Update(string email,Student aStudent)
        {
            return Ok(AllStudentInfo.UpdateStudent(email,aStudent));
        }

        [HttpDelete("{email}")]
        public ActionResult Delete(string email)
        {
            return Ok(AllStudentInfo.DeleteStudent(email));
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public static class AllStudentInfo
    {
        public static List<Student> Students { get; set; } = new List<Student>()
        {
            new Student()
            {
                Name = "Imtiaj Ahmed",
                Email = "sharif@gmail.com"
            },
            new Student()
            {
                Name = "Sumon Ahmed",
                Email = "sumon@gmail.com"
            }
        };

        public static List<Student> GetStudents()
        {
            return Students;
        }

        public static Student GetAStudent(string email)
        {
            return Students.FirstOrDefault(x => x.Email == email);
        }

        public static Student AddStudent(Student aStudent)
        {
            Students.Add(aStudent);
            return aStudent;
        }

        public static Student UpdateStudent(string email, Student aStudent)
        {
            foreach (var student in Students)
            {
                if(student.Email == email)
                {
                    student.Name = aStudent.Name;
                    student.Email = aStudent.Email;
                }
            }
            return aStudent;
        }

        public static Student DeleteStudent(string email)
        {
            var aStd = Students.FirstOrDefault(x => x.Email == email);
            var studentList = Students.Where(x => x.Email != email).ToList();
            Students = studentList;

            return aStd;
        }
        
    }
}
