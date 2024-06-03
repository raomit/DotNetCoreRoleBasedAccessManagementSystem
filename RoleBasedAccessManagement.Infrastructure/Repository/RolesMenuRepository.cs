using RoleBasedAccessManagement.Infrastructure.Models;
using RoleBasedAccessManagement.Infrastructure.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleBasedAccessManagement.Infrastructure.Repository
{
    public class RolesMenuRepository : IRepository<RolesMenu>
    {
        private readonly RaoMitContext _db;
        public RolesMenuRepository(RaoMitContext db)
        {
            this._db = db;
        }
        public RolesMenu AddSingle(RolesMenu entity)
        {
            var result = _db.RolesMenus.Add(entity);
            _db.SaveChanges();
            return result.Entity;
        }

        public void DeleteSingle(int id)
        {
            var ItemToDelete = _db.RolesMenus.Where(x => x.Id == id).FirstOrDefault();
            if (ItemToDelete != null)
            {
                _db.RolesMenus.Remove(ItemToDelete);
                _db.SaveChanges();
            }
        }

        public IEnumerable<RolesMenu> GetAll()
        {
            return _db.RolesMenus.ToList();
        }

        public RolesMenu GetSingleById(int id)
        {
            var ItemToGet = _db.RolesMenus.Where(x => x.Id == id).FirstOrDefault();
            return ItemToGet;
        }

        public RolesMenu UpdateSingle(int id, RolesMenu entity)
        {
            var ItemToUpdate = _db.RolesMenus.Where(x => x.Id == id).FirstOrDefault();

            if (ItemToUpdate != null)
            {
                ItemToUpdate.RoleId = entity.RoleId;
                ItemToUpdate.MenuId = entity.MenuId;
                _db.SaveChanges();
            }

            return ItemToUpdate;
        }
    }
}
