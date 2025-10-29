using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikKolledz.Models;

namespace TallinnaRakenduslikKolledz.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Delinquents> delinquents { get; set; }
        //
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseAssigment> CourseAssigments { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        public DbSet<Department> Departments { get; set; }
        public object Department { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Students");
            //
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<CourseAssigment>().ToTable("CourseAssignment");
            modelBuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignment");
            //
            modelBuilder.Entity<Department>().ToTable("Department");

            modelBuilder.Entity<Delinquents>().ToTable("delinquents");


        }
        

    }
}
