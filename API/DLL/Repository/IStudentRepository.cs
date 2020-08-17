using DLL.DbContext;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL.Repository
{
    public interface IStudentRepository
    {
        Student AddStudent(Student student);
        List<Student> GetAllStudent();
        Student GetAStudent(string email);
    }

    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public List<Student> GetAllStudent()
        {
            return _context.Students.ToList();
        }

        public Student GetAStudent(string email)
        {
            var student = _context.Students.FirstOrDefault(x => x.Email == email);
            return student;
        }
    }
}
