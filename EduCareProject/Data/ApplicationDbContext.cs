using EduCareProject.Models;
using Microsoft.AspNetCore.Identity;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Assignment>().HasData(
                new Assignment()
                {
                    Id = 1,
                    Title = "Tari si capitale",
                    Description = "Acesta este un quiz care testeaza cunostintele despre geografie ",
                    CreatedOn = DateTime.Now
                }
            );
            builder.Entity<Question>().HasData(
                new Question()
                {
                    Id = 1,
                    Content = "Capitala Romaniei este:",
                    AssignmentId = 1,
                    FirstAnswer = "Craiova",
                    SecondAnswer = "Bucuresti",
                    ThirdAnswer = "Cluj",
                    CorrectAnswer = 2
                },
                new Question()
                {
                    Id = 2,
                    Content = "Capitala Spaniei este:",
                    AssignmentId = 1,
                    FirstAnswer = "Madrid",
                    SecondAnswer = "Bergamo",
                    ThirdAnswer = "Barcelona",
                    CorrectAnswer = 1
                }
            );
            builder.Entity<Announcement>().HasData(
                new Announcement()
                {
                    Id = 1,
                    Title = "Bine ati venit!",
                    Description = "Acesta este primul anunt postat pe EduCare!",
                    CreatedOn = DateTime.Now
                }
            );

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole {
                    Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", 
                    Name = "Teacher", 
                    NormalizedName = "TEACHER".ToUpper() 
                },                
                new IdentityRole {
                    Id = "ed2c81ae-7c1d-41ce-b290-b70979d82af5", 
                    Name = "Student", 
                    NormalizedName = "STUDENT".ToUpper() 
                }
            );
            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    UserName = "myTeacher",
                    Email = "myTeacher@educare.ro",
                    NormalizedUserName = "MYTEACHER",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
                },
                new IdentityUser
                {
                    Id = "cd39d272-5656-487a-82f2-2467d87c3839", // primary key
                    UserName = "myStudent",
                    Email = "myStudent@educare.ro",
                    NormalizedUserName = "MYSTUDENT",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                },               
                new IdentityUserRole<string>
                {
                    RoleId = "ed2c81ae-7c1d-41ce-b290-b70979d82af5",
                    UserId = "cd39d272-5656-487a-82f2-2467d87c3839"
                }
            );
        }
    }
}

