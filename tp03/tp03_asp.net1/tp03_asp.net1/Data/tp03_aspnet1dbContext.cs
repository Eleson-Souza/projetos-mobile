using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tp03_asp.net1.Data
{
    public class tp03_aspnet1dbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public tp03_aspnet1dbContext() : base("name=tp03_aspnet1dbContext")
        {
        }

        public System.Data.Entity.DbSet<tp03_asp.net.Models.Login> Logins { get; set; }
    }
}
