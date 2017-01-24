
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youo.Domain;
using Youo.Domain.IRepositories;
using Youo.EntityFrameworkCore;

namespace Youo.EntityFrameworkCore.Repositories
{
    public class MenuRepository : YouoRepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(YouoDBContext dbcontext) : base(dbcontext)
        {

        }
    }
}
