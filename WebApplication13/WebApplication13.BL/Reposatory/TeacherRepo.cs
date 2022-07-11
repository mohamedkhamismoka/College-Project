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
    public class TeacherRepo : ITeacher
    {
        private readonly DataBase db;

        public TeacherRepo(DataBase db)
        {
            this.db = db;
        }
        public int getcount()
        {
            return db.Teachers.Count();
        }
        public string getTechearDepartmentName(int id)
        {
            var data = db.Teachers.Include("dept").Select(a => a);
            return data.Where(a=>a.TeacherId==id).Select(a=>a.dept.Name).FirstOrDefault();  
        }
        public void create(Teacher tech)
        {
            db.Teachers.Add(tech);
            db.SaveChanges();
        }

        public void delete(int id)
        {
            db.Teachers.Remove(db.Teachers.Find(id));
            db.SaveChanges();
        }

        public IEnumerable<Teacher> filter(Func<Teacher, bool> filter = null)
        {
           var data=db.Teachers.Where(filter);
            return data;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return db.Teachers.Include("dept").Select(a => a);
        }

        public Teacher Getbyid(int id)
        {
            return db.Teachers.Find(id);
        }

        public void update(Teacher tech)
        {
            db.Entry(tech).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
