using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication13.BL;
using WebApplication13.BL.VM;
using WebApplication13.DAL.Entities;

namespace WebApplication13.Controllers
{
    public class StudentCourseController : Controller
    {
        private readonly IMapper mapper;
        private readonly IStudent std;
        private readonly IstudentCourse std_Crs;
        private readonly IDepartment dept;
        private readonly ICourse crs;

        public StudentCourseController(IMapper mapper,IStudent std,IstudentCourse std_crs,IDepartment dept,ICourse crs)
        {
            this.mapper = mapper;
            this.std = std;
            std_Crs = std_crs;
            this.dept = dept;
            this.crs = crs;
        }
        public IActionResult Index(int id)
        {
            ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
            ViewBag.courses = new SelectList(crs.GetAll(), "CourseId", "Name");
            var data=std.Getbyid(id);
            var res = mapper.Map<StudentVM>(data);
            return View(res);
        }

        [HttpPost]
        public JsonResult Add(int std_id ,int crsid,int degree,int year,int term)
        {
            
                StudentcourseVM studentcourse = new StudentcourseVM()
                {
                    StudentId = std_id,
                    CourseId = crsid,
                    Academic_year = year,
                    Term = term,
                    degree = degree
                };
                var data = mapper.Map<Student_course>(studentcourse);
            try
            {
                std_Crs.create(data);
                return Json(new { state = 1,name=crs.getname(crsid),degree=degree });
            }
            catch
            {
                return Json(new { state = 0 });

            }
        }

        [HttpPost]
        public JsonResult update(int std_id, int crsid, int degree, int year, int term)
        {

            StudentcourseVM studentcourse = new StudentcourseVM()
            {
                StudentId = std_id,
                CourseId = crsid,
                Academic_year = year,
                Term = term,
                degree = degree
            };
            var data = mapper.Map<Student_course>(studentcourse);
            try
            {
                std_Crs.update(data);
                return Json(new { state = 1, name = crs.getname(crsid) });
            }
            catch
            {
                return Json(new { state = 0 });

            }
        }

        [HttpPost]

        public JsonResult Delete(int std_id, int crsid)
        {

           
            try
            {
                std_Crs.delete(std_id,crsid);
                return Json(new { state = 1, name = crs.getname(crsid) });
            }
            catch
            {
                return Json(new { state = 0 });

            }
        }
    }
}
