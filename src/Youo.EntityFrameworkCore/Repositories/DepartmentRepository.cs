using Youo.Domain;
using Youo.Domain.IRepositories;

namespace Youo.EntityFrameworkCore.Repositories
{
    public class DepartmentRepository : YouoRepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(YouoDBContext dbcontext) : base(dbcontext)
        {

        }
    }
}
