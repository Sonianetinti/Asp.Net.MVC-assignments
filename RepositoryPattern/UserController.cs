using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnDemand_CarWashSystem.Models;
using OnDemand_CarWashSystem.Services;

namespace OnDemand_CarWashSystem.Controllers
{
    public class UserController : ApiController
    {
        private UserServices _addServices;
        public UserController()
        {
            _addServices = new UserServices();
        }
        public UserController(UserServices addServices)
        {
            _addServices = addServices;
        }


        public string Post(UserTable user)
        {
            _addServices.Post(user);
            return "User Inserted successfully";
        }

        public IEnumerable<UserTable> GetAll()
        {
            return _addServices.GetAll();
        }

        public string Put(int Id, UserTable user)
        {
            _addServices.Put(Id, user);
            return "Users updated";
        }

        public string Delete(int Id)
        {
            _addServices.Delete(Id);

            return "Users deleted";
        }
        public UserTable GetbyId(int Id)
        {
            return (_addServices.GetbyId(Id));

        }
    }
}
    

