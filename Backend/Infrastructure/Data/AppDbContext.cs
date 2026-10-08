using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserResetPassword> UserResetPasswords { get; set; }
        public DbSet<ApplicationRequest> ApplicationRequests { get; set; }

        public DbSet<Activity> Activities { get; set; }

        public DbSet<ApplicationDocument> ApplicationDocuments { get; set; }

        public DbSet<AnnualPlan> AnnualPlans { get; set; }

        public DbSet<AnnualPlanItems> AnnualPlanItems { get; set; }

        public DbSet<Annex> Annexes { get; set; }
    }
}