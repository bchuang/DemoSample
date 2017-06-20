using DemoSample.Models.UserPermission;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSample.Database.CodeFirst
{
    public class DemoSampleDbContext : DbContext
    {
        public DemoSampleDbContext()
            : base("name=DemoSampleDbContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}