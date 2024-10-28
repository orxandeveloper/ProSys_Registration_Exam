using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ER.Domain.Models;

namespace ER.Domain
{
    public partial class ProSysExamContext : DbContext
    {
        public ProSysExamContext()
        {
        }

        public ProSysExamContext(DbContextOptions<ProSysExamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasIndex(e => e.CourseCode, "UQ__Courses__FC00E000F806BA63")
                    .IsUnique();

                entity.Property(e => e.CourseCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CourseName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.Property(e => e.ExamDate).HasColumnType("date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Exams_Courses");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_Exams_Students");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.StudentNumber, "UQ__Students__DD81BF6C612F32D0")
                    .IsUnique();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
