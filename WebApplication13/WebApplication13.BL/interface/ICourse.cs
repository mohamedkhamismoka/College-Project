using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Entities;

namespace WebApplication13.BL
{
    public interface ICourse
{
        public void create(Course crs);
        public void update(Course crs);

        public void delete(int id);

        public IEnumerable<Course> GetAll();

        public Course Getbyid(int id);

        public IEnumerable<Course > filter(Func<Course , bool> filter = null);
        public string getname(int? id);

        public int getcount();
    }
}
