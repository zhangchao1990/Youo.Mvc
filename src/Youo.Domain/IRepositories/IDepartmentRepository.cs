using Youo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Youo.Domain.IRepositories
{
    public interface IDepartmentRepository : IRepository<Department, Guid>
    {
    }
}
