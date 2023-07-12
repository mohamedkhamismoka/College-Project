using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace WebApplication13.BL.Reposatory
;
    public class StudentRepo : IStudent
    {

        private readonly DataBase db;
        public StudentRepo(DataBase db)
        {
            this.db = db;

        }
        public int getcount()
        {
            return db.Students.Count();
        }
        public void create(Student std)
        {
            db.Students.Add(std);
            db.SaveChanges();
        }

        public void delete(int id)
        {
            var data=db.Students.Find(id);
            db.Students.Remove(data);
            db.SaveChanges();
        }

        public IEnumerable<Student> filter(Func<Student, bool> filter = null)
        {
            var data = db.Students.Where(filter);
            return data;
        }

        public IEnumerable<Student> GetAll()
        {
            var data = db.Students.Include("dept").Select(a => a);
            return data;
        }

        public Student Getbyid(int id)
        {
            var data = db.Students.Find(id);
            return data;
        }

        public void update(Student std)
        {
            db.Entry(std).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

       public int  getCount(int deptid)
        {
            return db.Students.Where(a => a.DepartmentId == deptid).Count();

        }
    }

