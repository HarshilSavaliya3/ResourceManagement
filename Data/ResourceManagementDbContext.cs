using Microsoft.EntityFrameworkCore;
using ResourceManagement.UI.Models;
using System.Reflection.Emit;

namespace ResourceManagement.UI.Data
{
    public class ResourceManagementDbContext : DbContext
    {
        public ResourceManagementDbContext(DbContextOptions<ResourceManagementDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProjectRole>().HasKey(pr => new { pr.ProjectId, pr.RoleId });
            builder.Entity<EmployeeProject>().HasKey(pr => new { pr.ProjectId, pr.EmployeeId });
        }

        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Project>? Projects { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<ProjectRole>? ProjectRoles { get; set; }
        public DbSet<EmployeeProject>? EmployeeProjects { get; set; }
    }
}
