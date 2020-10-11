using DLL.DbContext;
using DLL.Models;
using DLL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    public interface IEmployeeInfoRepository : IRepositoryBase<EmployeeInfo>
    {
        
    }

    public class EmployeeInfoRepository : RepositoryBase<EmployeeInfo>, IEmployeeInfoRepository
    {
        public EmployeeInfoRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
