using System.Reflection;
using Eventom.Models.Event;
using Eventom.Models.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eventom.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options){}

        //public ApplicationDbContextcs(DbContextOptions options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public DbSet<Events> Events { get; set; }
        //public DbSet<Volunteers> Volunteers { get; set; }
        public DbSet<Applications> Applications { get; set; }
        public DbSet<Committees> Committees { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        //public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Eventom.Models.Event.Category> Category { get; set; } = default!;




    }
}
