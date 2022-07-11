using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using WebApplication13.BL;
using WebApplication13.BL.services;
using WebApplication13.DAL.Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication13.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent std;
        private readonly IMapper mapper;
        private readonly IDepartment dept;

        public StudentController(IStudent std,IMapper mapper, IDepartment dept)
        {
            this.std = std;
            this.mapper = mapper;
            this.dept = dept;
        }

        public IActionResult Index()
        {
            var data = std.GetAll();
            var res = mapper.Map<IEnumerable<StudentVM>>(data);
   

            return View(res);
        }
       
        public IActionResult Create()
        {
            ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
            return View();  
        }

        [HttpPost]
        public IActionResult Create(StudentVM student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   string imgname= fileUploader.upload("images", student.img);
                  
                   var data= mapper.Map<Student>(student); 
                    data.imgname = imgname;
                  
                    std.create(data);
                    return RedirectToAction("Index");
                }
              
                return View(student);
                
            }
            catch(Exception e)
            {
                ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
                return View(student);
            }
          
        }



        public IActionResult Details( int id)
        {
            var data = std.Getbyid(id);
            var res = mapper.Map<StudentVM>(data);
            ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name",data.DepartmentId);


            return View(res);
        }

        public IActionResult update(int id)
        {
            var data = std.Getbyid(id);
            var res = mapper.Map<StudentVM>(data);
            res.imgname = data.imgname;
            ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name", data.DepartmentId);
            return View(res);
        }
        [HttpPost]
        public IActionResult update(StudentVM student,string oldimg)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    if (student.img == null)
                    {
                        student.imgname = oldimg;
                        var updated_student = mapper.Map<Student>(student);

                        std.update(updated_student);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        string imgname = fileUploader.upload("images", student.img);
                        fileUploader.delete(student.imgname, "images");
                        var updated_student = mapper.Map<Student>(student);
                        updated_student.imgname = imgname;  
                        std.update(updated_student);
                        return RedirectToAction("Index");
                    }
                }
                student.imgname = oldimg;
                ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
                return View(student);
            }
            catch(Exception e)
            {
                ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
                return View(student);
            }
        }



        public IActionResult Delete(int id)
        {
            var data = std.Getbyid(id);
            var res = mapper.Map<StudentVM>(data);
            res.imgname = data.imgname;

            return View(res);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult conDelete(int id)
        {
            try
            {   var data=std.Getbyid(id);
                fileUploader.delete(data.imgname, "images");
                std.delete(id);
                return RedirectToAction("Index");

            }catch(Exception e)
            {
                return View(id);
            }
        }
    }
}
