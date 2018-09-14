namespace Birk.SchoolExample.DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SchoolExampleModel : DbContext
    {
        public SchoolExampleModel()
            : base("name=SchoolExampleModelT")
        {
        }

        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public virtual DbSet<OnlineCours> OnlineCourses { get; set; }
        public virtual DbSet<OnSiteCours> OnSiteCourses { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<StudentGrade> StudentGrades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cours>()
                .HasOptional(e => e.OnlineCours)
                .WithRequired(e => e.Cours);

            modelBuilder.Entity<Cours>()
                .HasOptional(e => e.OnSiteCours)
                .WithRequired(e => e.Cours);

            modelBuilder.Entity<Cours>()
                .HasMany(e => e.StudentGrades)
                .WithRequired(e => e.Cours)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cours>()
                .HasMany(e => e.Persons)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("CourseInstructors").MapLeftKey("CourseID").MapRightKey("PersonID"));

            modelBuilder.Entity<Department>()
                .Property(e => e.Budget)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OfficeAssignment>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.OfficeAssignment)
                .WithRequired(e => e.Person);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.StudentGrades)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.StudentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentGrade>()
                .Property(e => e.Grade)
                .HasPrecision(3, 2);
        }
    }
}
