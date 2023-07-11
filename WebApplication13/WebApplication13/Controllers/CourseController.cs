using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.BL;
using WebApplication13.BL.VM;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using WebApplication13.DAL.Entities;

namespace WebApplication13.Controllers;

    public class CourseController : Controller
    {
        private readonly ICourse crs;
        private readonly IMapper mapper;
        private readonly ITeacher tech;

        public CourseController(ICourse crs,IMapper mapper,ITeacher tech)
        {
           this.crs = crs;
            this.mapper = mapper;
            this.tech = tech;
        }
      
        public IActionResult Index()
        {
            var data=crs.GetAll();
            var res = mapper.Map<IEnumerable<CourseVM>>(data);
            return View(res);
        }

        public IActionResult Create()
        {
            ViewBag.teachers = new SelectList(tech.GetAll(), "TeacherId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CourseVM crsVm)
        {
            try
            {
                if (ModelState.IsValid)
                { var data = mapper.Map<Course>(crsVm);
                    crs.create(data);
                    return RedirectToAction("Index");
                }
                ViewBag.teachers = new SelectList(tech.GetAll(), "TeacherId", "Name");
                return View(crsVm);

            }
            catch(Exception e)
            {
                ViewBag.teachers = new SelectList(tech.GetAll(), "TeacherId", "Name");
                return View(crsVm);
            }
          
        }

      public IActionResult update(int id)
        {
            ViewBag.teachers = new SelectList(tech.GetAll(), "TeacherId", "Name");
            var data=crs.Getbyid(id);
            var res = mapper.Map<CourseVM>(data);
            return View(res);
        }

        [HttpPost]
        public IActionResult update(CourseVM crsVm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Course>(crsVm);
                    crs.update(data);
                    return RedirectToAction("Index");
                }
                ViewBag.teachers = new SelectList(tech.GetAll(), "TeacherId", "Name");
                return View(crsVm);

            }
            catch (Exception e)
            {
                ViewBag.teachers = new SelectList(tech.GetAll(), "TeacherId", "Name");
                return View(crsVm);
            }

        }

        public IActionResult Delete(int id)
        {
            ViewBag.teachers = new SelectList(tech.GetAll(), "TeacherId", "Name");
            var data = crs.Getbyid(id);
            var res = mapper.Map<CourseVM>(data);
            return View(res);
        }
        [ActionName("Delete")]
        [HttpPost]
        public IActionResult conDelete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                
                    crs.delete(id);
                    return RedirectToAction("Index");
                }
                ViewBag.teachers = new SelectList(tech.GetAll(), "TeacherId", "Name");
                return View();

            }
            catch (Exception e)
            {
                ViewBag.teachers = new SelectList(tech.GetAll(), "TeacherId", "Name");
                return View();
            }
        }

        public IActionResult Details(int id)
        {
            ViewBag.teachers = new SelectList(tech.GetAll(), "TeacherId", "Name");
            var data = crs.Getbyid(id);
            var res = mapper.Map<CourseVM>(data);
            return View(res);

        }
    }

