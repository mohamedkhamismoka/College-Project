using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Database;
using WebApplication13.DAL.Entities;

namespace WebApplication13.BL.Reposatory
{
    public class CourseRepo : ICourse
    {
        private readonly DataBase db;

        public CourseRepo(DataBase db)
        {
            this.db = db;
        }

        public string getname(int? id)
        {
            return db.Courses.Where(a=>a.CourseId==id).Select(a=>a.Name).FirstOrDefault();
        }
        public void create(Course crs)
        {
          db.Courses.Add(crs);
            db.SaveChanges();
        }

        public void delete(int id)
        {
           db.Courses.Remove(db.Courses.Find(id));
            db.SaveChanges();
        }

        public IEnumerable<Course> filter(Func<Course, bool> filter = null)
        {
            return db.Courses.Where(filter);
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.Include("Teacher").Select(a=>a);
        }

        public Course Getbyid(int id)
        {
            return db.Courses.Find(id);
        }

        public void update(Course crs)
        {
            db.Entry(crs).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public int getcount()
        {
            return db.Courses.Count();
        }
    }
}
