

namespace WebApplication13.BL;

    public interface ITeacher
{

        public void create(Teacher tech);
        public void update(Teacher tech);

        public void delete(int id);

        public IEnumerable<Teacher> GetAll();

        public Teacher Getbyid(int id);

        public IEnumerable<Teacher> filter(Func<Teacher, bool> filter = null);
        public string getTechearDepartmentName(int id);

        public int getcount();
    }

