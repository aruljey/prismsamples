using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration.Modules.UserForm.Model;

namespace WPFCrud.EntityFramework
{
    public class DataContext : DbContext
    {
        public DataContext() : base("WPFCrud")
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
