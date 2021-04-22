using EduCareProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduCare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Assignment>().HasData(
                new Assignment()
                {
                    Id = 1,
                    Title = "First assignment",
                    Description = "ABCDEF",
                    CreatedOn = DateTime.Now
                }
            );
            builder.Entity<Question>().HasData(
                new Question()
                {
                    Id = 1,
                    Content = "ABC",
                    AssignmentId = 1
                }
                );

        }
    }
}

