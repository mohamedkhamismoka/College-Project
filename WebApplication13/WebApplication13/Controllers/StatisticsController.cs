using AutoMapper;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebApplication13.BL;
using WebApplication13.BL.VM;
using WebApplication13.DAL.Database;

namespace WebApplication13.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IMapper mapper;
        private readonly IStudent std;
        private readonly IstudentCourse stdcrs;
        private readonly IPayment pay;
        private readonly ICourse crs;

        public StatisticsController(IMapper mapper,IStudent std,IstudentCourse stdcrs,IPayment pay, ICourse crs)
        {
            this.mapper = mapper;
            this.std = std;
            this.stdcrs = stdcrs;
            this.pay = pay;
            this.crs = crs;
        }
        public IActionResult Index()
        {
            ViewBag.courses = new SelectList(crs.GetAll(), "CourseId", "Name");
            ViewBag.students= new SelectList(std.GetAll(), "StudentId", "Name");
            return View();
        }
        public IActionResult GetDegree(int courseid)
        {  
            var data = from x in stdcrs.getAll()
                       where x.CourseId == courseid
                       orderby x.degree descending
                       select x;
            ViewBag.passes =  (from x in stdcrs.getAll()
                             where x.CourseId == courseid && x.degree >= 50

                             select x).Count() ;
            ViewBag.failed = (from x in stdcrs.getAll()
                              where x.CourseId == courseid && x.degree < 50

                              select x).Count();


            var res = mapper.Map<IEnumerable<StudentcourseVM>>(data);
            return View(res);

        }
        public IActionResult GetPayment(int studentid)
        {
            var data = pay.GetAll().Where(a => a.StudentId == studentid);
            var res = mapper.Map<IEnumerable<paymentVM>>(data);
            ViewBag.stdid = studentid;
            return View(res);
        }
      
    }
}
