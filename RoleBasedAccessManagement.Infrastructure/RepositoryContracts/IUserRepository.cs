using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleBasedAccessManagement.Infrastructure.Models;

namespace RoleBasedAccessManagement.Infrastructure.RepositoryContracts
{
    public interface IUserRepository : IRepository<User>
    {
        User GetSingleByEmail(string email);
    }
}
