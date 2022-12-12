using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnDemand_CarWashSystem.Models;

namespace OnDemand_CarWashSystem.Repository
{
    public interface IUser
    {
        IEnumerable<UserTable> GetAll();
        UserTable GetById(int Id);
        void Post(UserTable user);
        void Put(int Id, UserTable user);
        void Delete(int Id);
        void Save();
    }
}