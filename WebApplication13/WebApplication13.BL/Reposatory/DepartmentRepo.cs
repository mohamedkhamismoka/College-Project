using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Database;
using WebApplication13.DAL.Entities;

namespace WebApplication13.BL.Reposatory
{
    public class DepartmentRepo : IDepartment
    {
        private readonly DataBase db;

        public DepartmentRepo(DataBase db)
        {
            this.db = db;
        }

        public int getcount()
        {
            return db.departments.Count();
        }
        public void create(Department dep)
        {
         db.departments.Add(dep);   
            db.SaveChanges();
        }

        public void delete(int id)
        {
            db.departments.Remove(db.departments.Find(id));
            db.SaveChanges();
        }

        public IEnumerable<Department> filter(Func<Department, bool> filter = null)
        {
           return db.departments.Where(filter);
        }

        public IEnumerable<Department> GetAll()
        {
            return db.departments.Select(a => a);
        }

        public Department Getbyid(int id)
        {
            return db.departments.Find(id);
        }

        public void update(Department dept)
        {
            db.Entry(dept).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
