using DLL.DbContext;
using DLL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    public interface IStudentRepository
    {
        Task<Student> AddStudentAsync(Student student);
        Task<List<Student>> GetAllStudentAsync();
        Task<Student> GetAStudentAsync(string email);
    }

    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<List<Student>> GetAllStudentAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetAStudentAsync(string email)
        {
            var student = await _context.Students.FirstOrDefaultAsync(x => x.Email == email);
            return student;
        }
    }
}
