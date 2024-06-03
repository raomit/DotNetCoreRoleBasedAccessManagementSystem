using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleBasedAccessManagement.Infrastructure.RepositoryContracts
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetSingleById(int id);
        T AddSingle(T entity);
        T UpdateSingle(int id, T entity);
        void DeleteSingle(int id);

    }
}
