using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Miguel.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConection")
        {

        }

        public System.Data.Entity.DbSet<Miguel.Models.Clown> Clowns { get; set; }
    }
}