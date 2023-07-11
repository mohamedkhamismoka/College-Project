﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Entities;

namespace WebApplication13.DAL.Database
;
    public class DataBase:DbContext
    {

        public DataBase(DbContextOptions<DataBase> db):base(db)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_course>().HasKey(a => new {a.Std_Id,a.Crs_Id});

        modelBuilder.Entity<Student>()
      .HasMany(p => p
      .Students_courses)
      .WithOne(t => t.student)
      .OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<Course>()
     .HasMany(p => p.Students_course)
     .WithOne(t => t.course)
     .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Department>()
            
             .HasMany(p => p.Students)
             .WithOne(t => t.dept)
             .OnDelete(DeleteBehavior.Cascade);



    }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<Payment> payments { get; set; }
        public virtual DbSet<Department> departments { get; set; }


        public virtual DbSet<Student_course> student_Courses { get; set; }  
        

    }

