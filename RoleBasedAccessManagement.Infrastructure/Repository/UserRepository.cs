using RoleBasedAccessManagement.Infrastructure.Models;
using RoleBasedAccessManagement.Infrastructure.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleBasedAccessManagement.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RaoMitContext _db;

        public UserRepository(RaoMitContext db)
        {
            db = _db;
        }

        public User GetSingleByEmail(string email)
        {
            var ItemToGet = _db.Users.Where(x => x.Email == email).FirstOrDefault();
            return ItemToGet;
        }

        public User AddSingle(User entity)
        {
            var result = _db.Users.Add(entity);
            _db.SaveChanges();
            return result.Entity;
        }

        public void DeleteSingle(int id)
        {
            var ItemToDelete = _db.Users.Where(x => x.UserId == id).FirstOrDefault();
            if (ItemToDelete != null)
            {
                _db.Users.Remove(ItemToDelete);
                _db.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            return _db.Users.ToList();
        }

        public User GetSingleById(int id)
        {
            var ItemToGet = _db.Users.Where(x => x.UserId == id).FirstOrDefault();
            return ItemToGet;
        }

        public User UpdateSingle(int id, User entity)
        {
            var ItemToUpdate = _db.Users.Where(x => x.UserId == id).FirstOrDefault();

            if (ItemToUpdate != null)
            {
                ItemToUpdate.FullName = entity.FullName;
                ItemToUpdate.BirthDate = entity.BirthDate;
                ItemToUpdate.ContactNo = entity.ContactNo;
                ItemToUpdate.Email = entity.Email;
                ItemToUpdate.Password = entity.Password;

                _db.SaveChanges();
            }
            return ItemToUpdate;
        }
    }
}
