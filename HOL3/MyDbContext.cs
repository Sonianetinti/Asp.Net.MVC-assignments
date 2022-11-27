using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace HOL3.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext():base("conn")
        {

        }
        public DbSet<User> Users { get; set; }

    }
}