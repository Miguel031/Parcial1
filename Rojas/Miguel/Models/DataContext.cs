using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miguel.Models
{
    public class DataContext:DbContex
    {
        public DataContext():base("DefaultConection")
        {

        }
    }
}