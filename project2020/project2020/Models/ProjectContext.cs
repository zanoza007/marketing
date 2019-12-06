using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ProjectContext : IdentityDbContext
    {
        public new DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Offers> Offers { get; set; }
        public DbSet<TypeOfOrders> TypeOfOrders { get; set; }
        public DbSet<Workers> Workers { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().HasKey(u => u.Id);
        }
       
        public ProjectContext()
        { }
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
