using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleBasedAccessManagement.Infrastructure.Models;
using RoleBasedAccessManagement.Infrastructure.RepositoryContracts;

namespace RoleBasedAccessManagement.Infrastructure.Repository
{
    public class MenuRepository : IRepository<Menu>
    {
        private readonly RaoMitContext _db;

        public MenuRepository(RaoMitContext db)
        {
            this._db = db;
        }

        public Menu AddSingle(Menu entity)
        {
            var result = _db.Menus.Add(entity);
            _db.SaveChanges();
            return result.Entity;
        }

        public void DeleteSingle(int id)
        {
            var ItemToDelete = _db.Menus.Where(x => x.MenuId == id).FirstOrDefault();
            if(ItemToDelete != null)
            {
                _db.Menus.Remove(ItemToDelete);
                _db.SaveChanges();
            }
        }

        public IEnumerable<Menu> GetAll()
        {
            return _db.Menus.ToList();
        }

        public Menu GetSingleById(int id)
        {
            var ItemToGet = _db.Menus.Where(x => x.MenuId == id).FirstOrDefault();
            return ItemToGet;
        }

        public Menu UpdateSingle(int id, Menu entity)
        {
            var ItemToUpdate = _db.Menus.Where(x => x.MenuId == id).FirstOrDefault();

            if(ItemToUpdate != null)
            {
                ItemToUpdate.MenuType = entity.MenuType;
                _db.SaveChanges();
            }
            return ItemToUpdate;
        }
    }
}
