using DbExam.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExam
{
    internal class DepartmentContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lecture> Lectures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-V89QDG3\\SQLEXPRESS01;Database=DbOfExam;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }

    }
}
