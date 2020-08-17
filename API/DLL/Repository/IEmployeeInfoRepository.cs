using DLL.DbContext;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL.Repository
{
    public interface IEmployeeInfoRepository
    {
        List<EmployeeInfo> GetAllEmployee();
        EmployeeInfo GetAEmployee(string email);
        EmployeeInfo AddEmployeeInfo(EmployeeInfo employeeInfo);        
    }

    public class EmployeeInfoRepository : IEmployeeInfoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeInfoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public EmployeeInfo AddEmployeeInfo(EmployeeInfo employeeInfo)
        {
            _dbContext.EmployeeInfos.Add(employeeInfo);
            _dbContext.SaveChanges();
            return employeeInfo;
        }

        public EmployeeInfo GetAEmployee(string email)
        {
            var aEmployee = _dbContext.EmployeeInfos.FirstOrDefault(e => e.Email == email);
            return aEmployee;
        }

        public List<EmployeeInfo> GetAllEmployee()
        {
            return _dbContext.EmployeeInfos.ToList();
        }
    }
}
