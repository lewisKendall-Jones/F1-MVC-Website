using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace f1website.Data
{
    public class f1WebsiteContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public f1WebsiteContext() : base("name=f1WebsiteContext")
        {
        }

        public System.Data.Entity.DbSet<f1website.Models.Result> Results { get; set; }

        public System.Data.Entity.DbSet<f1website.Models.Category> Categories { get; set; }
    }
}
