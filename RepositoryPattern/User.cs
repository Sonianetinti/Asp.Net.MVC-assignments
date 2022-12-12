using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnDemand_CarWashSystem.Models;

namespace OnDemand_CarWashSystem.Repository
{
    public class User:IUser
    {
        private readonly CarWashEntities _context;
        public User()
        {
            _context = new CarWashEntities();
        }
        public User(CarWashEntities context)
        {
            _context = context;
        }
        public IEnumerable<UserTable> GetAll()
        {
            return _context.UserTables.ToList();
        }
        public UserTable GetById(int Id)
        {
            return _context.UserTables.Find(Id);
        }
        public void Post(UserTable user)
        {
            _context.UserTables.Add(user);
            _context.SaveChanges();
        }
        public void Put(int Id, UserTable user)
        {
            var _user = _context.UserTables.Find(Id);
            _user.Id = user.Id;
            _user.FirstName = user.FirstName;
            _user.LastName = user.LastName;
            _user.PhoneNumber = user.PhoneNumber;
            _user.Email = user.Email;
            _user.Password = user.Password;
            _user.Role = user.Role;
            _user.Status = user.Status;
            _context.SaveChanges();

        }
        public void Delete(int Id)
        {
            UserTable user = _context.UserTables.Find(Id);
            _context.UserTables.Remove(user);
            _context.SaveChanges();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

    
