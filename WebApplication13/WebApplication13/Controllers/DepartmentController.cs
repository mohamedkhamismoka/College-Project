using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication13.BL;
using WebApplication13.BL.VM;
using WebApplication13.DAL.Entities;

namespace WebApplication13.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartment department;
        private readonly IMapper mapper;

        public DepartmentController(IDepartment department, IMapper mapper)
        {
            this.department = department;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var data = department.GetAll();
            var res = mapper.Map<IEnumerable<DepartmentVM>>(data);
            return View(res);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentVM dept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Department>(dept);
                    department.create(data);
                    return RedirectToAction("Index");
                }
                return View(dept);
            }
            catch (Exception e)
            {
                return View(dept);
            }
        }


        public IActionResult update(int id)
        {
            var data = department.Getbyid(id);
            var res = mapper.Map<DepartmentVM>(data);
            return View(res);
        }
        [HttpPost]
        public IActionResult update(DepartmentVM dept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Department>(dept);
                    department.update(data);
                    return RedirectToAction("Index");
                }
                return View(dept);

            }
            catch (Exception e)
            {
                return View(dept);
            }
        }


        public IActionResult Details(int id)
        {
            var data = department.Getbyid(id);
            var res = mapper.Map<DepartmentVM>(data);
            return View(res);

        }



        public IActionResult Delete(int id)
        {
            var data = department.Getbyid(id);
            var res = mapper.Map<DepartmentVM>(data);
            return View(res);

        }


        [ActionName("Delete")]
        [HttpPost]
        public IActionResult ConDelete(int id)
        {
            try
            {

                department.delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }


        }
    }
}
