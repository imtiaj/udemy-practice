using BLL.Request;
using DLL.Models;
using DLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility.Exceptions;

namespace BLL.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeInfo>> GetAllEmployeeAsync();
        Task<EmployeeInfo> GetAEmployeeAsync(string email);
        Task<EmployeeInfo> AddEmployeeInfoAsync(EmployeeAddRequest employeeAddRequest);
        //Task<EmployeeInfo> UpdateEmployeeAsync(string email, EmployeeUpdateRequest updateRequest);
        Task<EmployeeInfo> DeleteEmployee(string email);

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
            DateTime dateTime = DateTime.UtcNow;
            EmployeeInfo employeeInfo = new EmployeeInfo
            {
                FirstName = employeeAddRequest.FirstName,
                LastName = employeeAddRequest.LastName,
                Email = employeeAddRequest.Email,
                NationalID = employeeAddRequest.NationalID
            };
            await employeeInfoRepository.CreateAsync(employeeInfo);

            if (await employeeInfoRepository.EntitySaveChangeAsync())
            {
                return employeeInfo;
            }
            else
            {
                throw new ApiExceptions("somthing went wrong");
            }
        }

        public async Task<EmployeeInfo> GetAEmployeeAsync(string email)
        { 
            var aEmployee = await employeeInfoRepository.GetAAsync(e => e.Email == email);
            if (aEmployee == null)
            {
                throw new ApiExceptions("employee not found");
            }
            return aEmployee;
        }

        public async Task<List<EmployeeInfo>> GetAllEmployeeAsync()
        {
            return await employeeInfoRepository.GetAllAsync();
        }

        public async Task<bool> IsEmailExist(string email)
        {
            var empEmail = await employeeInfoRepository.GetAAsync(e => e.Email == email);
            if(empEmail != null)
            {
                // return true means data is insertable in db
                return false;  
            }
            return true;
        }

        public async Task<bool> IsNIDExist(string nationalId)
        {
            var empNID = await employeeInfoRepository.GetAAsync(e => e.NationalID == nationalId);
            if (empNID != null)
            {
                // return true means data is insertable in db
                return false;
            }
            return true;
        }


        //public async Task<EmployeeInfo> UpdateEmployeeBasicProfile(string email, EmployeeUpdateRequest request)
        //{
        //    var aEmpInfo = await employeeInfoRepository.GetAEmployeeAsync(email);            

        //    aEmpInfo.FirstName = request.FirstName;
        //    aEmpInfo.LastName = request.LastName;
        //    aEmpInfo.NationalID = request.NationalID;
        //    aEmpInfo.DateOfBirth = request.DateOfBirth;
        //    aEmpInfo.Gender = request.Gender;
        //    aEmpInfo.Email = request.Email;

        //    if (!string.IsNullOrWhiteSpace(request.Email))
        //    {
        //        var isEmailExistInOtherEmpInfo = await employeeInfoRepository.GetAAsync(
        //                                            emp => emp.Email == request.Email
        //                                            && emp.EmployeeID != aEmpInfo.EmployeeID);
        //        if (isEmailExistInOtherEmpInfo == null)
        //        {
        //            aEmpInfo.Email = request.Email;
        //        }
        //        else
        //        {
        //            throw new RapsAppException("Email already exist in another employees info.");
        //        }
        //    }

        //    if (!string.IsNullOrWhiteSpace(request.MobileNumber))
        //    {
        //        var isMobileNumberExistInOtherEmpInfo = await _empBasicInfoRepository.GetAAsync(
        //                                            emp => emp.MobileNumber == request.MobileNumber
        //                                            && emp.EmployeeID != aEmpInfo.EmployeeID);
        //        if (isMobileNumberExistInOtherEmpInfo == null)
        //        {
        //            aEmpInfo.MobileNumber = request.MobileNumber;
        //        }
        //        else
        //        {
        //            throw new RapsAppException("Mobile number already exist in another employees info.");
        //        }
        //    }

        //    if (!string.IsNullOrWhiteSpace(request.NID))
        //    {
        //        var isNIDExistInOtherEmpInfo = await _empBasicInfoRepository.GetAAsync(
        //                                            emp => emp.NID == request.NID
        //                                            && emp.EmployeeID != aEmpInfo.EmployeeID);
        //        if (isNIDExistInOtherEmpInfo == null)
        //        {
        //            aEmpInfo.NID = request.NID;
        //        }
        //        else
        //        {
        //            throw new RapsAppException("National ID already exist in another employees info.");
        //        }
        //    }

        //    _empBasicInfoRepository.UpdateAsync(aEmpInfo);
        //    // var a = await _empBasicInfoRepository.testUpdate(aEmpInfo);

        //    if (await _empBasicInfoRepository.ApplySaveChangesAsync())
        //    {
        //        return aEmpInfo;
        //    }
        //    throw new RapsAppException("somthing went worng");
        //}

        public async Task<EmployeeInfo> DeleteEmployee(string email)
        {
            var empInfo = await employeeInfoRepository.GetAAsync(e => e.Email == email);

            if (empInfo == null)
            {
                throw new ApiExceptions("Employee not found");
            }

            employeeInfoRepository.Delete(empInfo);

            if (await employeeInfoRepository.EntitySaveChangeAsync())
            {
                return empInfo;
            }
            throw new ApiExceptions("somthing went worng");
        }
    }
}
