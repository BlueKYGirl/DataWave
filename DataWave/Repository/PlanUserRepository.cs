using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class PlanUserRepository : RepositoryBase<PlanUser>, IPlanUserRepository
    {
        public PlanUserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
