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
    public interface IEmployeeInfoRepository
    {
        Task<List<EmployeeInfo>> GetAllEmployeeAsync();
        Task<EmployeeInfo> GetAEmployeeAsync(string email);
        Task<EmployeeInfo> AddEmployeeInfoAsync(EmployeeInfo employeeInfo);
        Task<bool> IsNIDExist(string nationalId);
        Task<bool> IsEmailExist(string email);
    }

    public class EmployeeInfoRepository : IEmployeeInfoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeInfoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<EmployeeInfo> AddEmployeeInfoAsync(EmployeeInfo employeeInfo)
        {
            await _dbContext.EmployeeInfos.AddAsync(employeeInfo);
            await _dbContext.SaveChangesAsync();
            return employeeInfo;
        }

        public async Task<EmployeeInfo> GetAEmployeeAsync(string email)
        {
            var aEmployee = await _dbContext.EmployeeInfos.FirstOrDefaultAsync(e => e.Email == email);
            return aEmployee;
        }

        public async Task<List<EmployeeInfo>> GetAllEmployeeAsync()
        {
            return await _dbContext.EmployeeInfos.ToListAsync();
        }

        public async Task<bool> IsEmailExist(string email)
        {
            var empEmail = await _dbContext.EmployeeInfos.FirstOrDefaultAsync(e => e.Email == email);
            if(empEmail != null)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> IsNIDExist(string nationalId)
        {
            var empNid = await _dbContext.EmployeeInfos.FirstOrDefaultAsync(e => e.NationalID == nationalId);
            if (empNid != null)
            {
                return false;
            }
            return true;
        }
    }
}
