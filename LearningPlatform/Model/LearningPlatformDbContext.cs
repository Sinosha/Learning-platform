using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LearningPlatform.Model
{
    public class LearningPlatformDbContext : DbContext
    {
        public  LearningPlatformDbContext()
        {
            try
            {
                Database.EnsureCreated();
            }
            catch
            {

            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Academy.db");
            string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Academy;Integrated Security=true;TrustServerCertificate=True;Encrypt=False;";
            optionsBuilder.UseSqlServer(connection);

        }
        public DbSet<Event>? Events { get; set; }
        public DbSet<Group>? Groups { get; set; }
        public DbSet<User>? ApplicationUsers { get; set; }
        public DbSet<UserData>? UserDatas { get; set; }
        public DbSet<Mark>? Marks { get; set; }
        public DbSet<Subject>? Subjects { get; set; }
        public DbSet<Test>? Tests { get; set; }
        public DbSet<Question>? Questions { get; set; }
    }

}
