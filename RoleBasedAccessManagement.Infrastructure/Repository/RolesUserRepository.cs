using RoleBasedAccessManagement.Infrastructure.Models;
using RoleBasedAccessManagement.Infrastructure.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleBasedAccessManagement.Infrastructure.Repository
{
    public class RolesUserRepository : IRepository<RolesUser>
    {
        private readonly RaoMitContext _db;
        public RolesUserRepository(RaoMitContext db)
        {
            this._db = db;
        }
        public RolesUser AddSingle(RolesUser entity)
        {
            var result = _db.RolesUsers.Add(entity);
            _db.SaveChanges();
            return result.Entity;
        }

        public void DeleteSingle(int id)
        {
            var ItemToDelete = _db.RolesUsers.Where(x => x.Id == id).FirstOrDefault();
            if (ItemToDelete != null)
            {
                _db.RolesUsers.Remove(ItemToDelete);
                _db.SaveChanges();
            }
        }

        public IEnumerable<RolesUser> GetAll()
        {
            return _db.RolesUsers.ToList();
        }

        public RolesUser GetSingleById(int id)
        {
            var ItemToGet = _db.RolesUsers.Where(x => x.Id == id).FirstOrDefault();
            return ItemToGet;
        }

        public RolesUser UpdateSingle(int id, RolesUser entity)
        {
            var ItemToUpdate = _db.RolesUsers.Where(x => x.Id == id).FirstOrDefault();

            if (ItemToUpdate != null)
            {
                ItemToUpdate.RoleId = entity.RoleId;
                ItemToUpdate.UserId = entity.UserId;
                _db.SaveChanges();
            }

            return ItemToUpdate;
        }
    }
}
