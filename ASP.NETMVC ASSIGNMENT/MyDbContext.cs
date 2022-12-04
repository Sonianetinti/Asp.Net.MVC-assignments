using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Ado.netmvcAssignment.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext():base("name=conn")
        {

        }
        public DbSet<FootballLeague> FootBallLeague { get; set; }
            
    }
}