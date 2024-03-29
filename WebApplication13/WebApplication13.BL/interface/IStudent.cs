﻿

namespace WebApplication13.BL
;
    public interface IStudent
{

        public void create(Student std);
        public void update(Student std);

        public void delete(int id);

        public IEnumerable<Student> GetAll();

        public Student Getbyid(int id);

        public IEnumerable<Student> filter(Func<Student, bool> filter = null);
        public int getCount(int deptid);

        public int getcount();
    }

