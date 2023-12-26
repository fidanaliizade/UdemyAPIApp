using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTask.Core.Entities;

namespace UdemyTask.DAL.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasOne(s => s.Parent)
                .WithMany(m => m.Children)
                .HasForeignKey(e => e.ParentCategoryId);
            base.OnModelCreating(modelBuilder);
        }
		public virtual DbSet<Category> categories { get; set; }
		public DbSet<Course> courses { get; set; }
		public DbSet<Student> students { get; set; }
		public DbSet<StudentCourse> studentsCourse { get; set; }
		public DbSet<Teacher> teachers { get; set; }
	}
}
