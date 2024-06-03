using RoleBasedAccessManagement.Infrastructure.Models;
using RoleBasedAccessManagement.Infrastructure.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleBasedAccessManagement.Infrastructure.Repository
{
    public class RoleRepository : IRepository<Role>
    {
        private readonly RaoMitContext _db;

        public RoleRepository(RaoMitContext db)
        {
            this._db = db;
        }
        public Role AddSingle(Role entity)
        {
            var result = _db.Roles.Add(entity);
            _db.SaveChanges();
            return result.Entity;
        }

        public void DeleteSingle(int id)
        {
            var ItemToDelete = _db.Roles.Where(x => x.RoleId == id).FirstOrDefault();
            if (ItemToDelete != null)
            {
                _db.Roles.Remove(ItemToDelete);
                _db.SaveChanges();
            }
        }

        public IEnumerable<Role> GetAll()
        {
            return _db.Roles.ToList();
        }

        public Role GetSingleById(int id)
        {
            var ItemToGet = _db.Roles.Where(x => x.RoleId == id).FirstOrDefault();
            return ItemToGet;
        }

        public Role UpdateSingle(int id, Role entity)
        {
            var ItemToUpdate = _db.Roles.Where(x => x.RoleId == id).FirstOrDefault();

            if (ItemToUpdate != null)
            {
                ItemToUpdate.RoleType = entity.RoleType;
                _db.SaveChanges();
            }
            return ItemToUpdate;
        }
    }
}
