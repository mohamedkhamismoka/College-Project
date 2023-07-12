using System;
using System.Collections.Generic;

using WebApplication13.DAL.Entities;

namespace WebApplication13.BL;

    public interface IDepartment
{

        public void create(Department dep);
        public void update(Department dept);

        public void delete(int id);

        public IEnumerable<Department> GetAll();

        public Department Getbyid(int id);

        public IEnumerable<Department> filter(Func<Department, bool> filter = null);
        public int getcount();
    }

