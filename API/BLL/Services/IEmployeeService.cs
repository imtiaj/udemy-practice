using BLL.Request;
using DLL.Models;
using DLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeInfo>> GetAllEmployeeAsync();
        Task<EmployeeInfo> GetAEmployeeAsync(string email);
        Task<EmployeeInfo> AddEmployeeInfoAsync(EmployeeAddRequest employeeAddRequest);

        Task<Boolean> IsNIDExist(string nationalId);
        Task<Boolean> IsEmailExist(string email);
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeInfoRepository employeeInfoRepository;

        public EmployeeService(IEmployeeInfoRepository EmployeeInfoRepository)
        {
            employeeInfoRepository = EmployeeInfoRepository;
        }

        public async Task<EmployeeInfo> AddEmployeeInfoAsync(EmployeeAddRequest employeeAddRequest)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo
            {
                FirstName = employeeAddRequest.FirstName,
                LastName = employeeAddRequest.LastName,
                Email = employeeAddRequest.Email,
                DateOfBirth = employeeAddRequest.DateOfBirth,
                Gender = employeeAddRequest.Gender,
                NationalID = employeeAddRequest.NationalID
            };
            return await employeeInfoRepository.AddEmployeeInfoAsync(employeeInfo);
        }

        public async Task<EmployeeInfo> GetAEmployeeAsync(string email)
        {            
            return await employeeInfoRepository.GetAEmployeeAsync(email);
        }

        public async Task<List<EmployeeInfo>> GetAllEmployeeAsync()
        {
            return await employeeInfoRepository.GetAllEmployeeAsync();
        }

        public async Task<bool> IsEmailExist(string email)
        {
            return await employeeInfoRepository.IsEmailExist(email);
        }

        public async Task<bool> IsNIDExist(string nationalId)
        {
            return await employeeInfoRepository.IsNIDExist(nationalId);
        }
    }
}
