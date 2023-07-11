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
using System.IO;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApplication13.Controllers;

public class StudentController : Controller
{
    private readonly IStudent std;
    private readonly IMapper mapper;
    private readonly IDepartment dept;
    private readonly IstudentCourse stdCrs;

    public StudentController(IStudent std, IMapper mapper, IDepartment dept, IstudentCourse stdCrs)
    {
        this.std = std;
        this.mapper = mapper;
        this.dept = dept;
        this.stdCrs = stdCrs;
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
                string imgname = fileUploader.upload("images", student.img);

                var data = mapper.Map<Student>(student);
                data.imgname = imgname;

                std.create(data);
                return RedirectToAction("Index");
            }
            ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
            return View(student);

        }
        catch (Exception e)
        {
            ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
            return View(student);
        }

    }



    public IActionResult Details(int id)
    {
        var data = std.Getbyid(id);
        var res = mapper.Map<StudentVM>(data);
        ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name", data.DepartmentId);


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
    public IActionResult update(StudentVM student, IFormFile newimg, string oldimg)
    {
        try
        {
            if (newimg == null)
            {
                student.imgname = oldimg;
            }
            else
            {
                fileUploader.delete(oldimg, "images");
                student.imgname = fileUploader.upload("images", newimg);
            }


            if (!ModelState.IsValid)
            {

                if (student.img == null && ModelState.Root.Children[0].ValidationState== ModelValidationState.Invalid)
                {
                    var updated_student = mapper.Map<Student>(student);

                    std.update(updated_student);
                    return RedirectToAction("Index");
                }
                else
                {
                    student.imgname = oldimg;
                    ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
                    return View(student);

                }







            }
            else {

                var updated_student = mapper.Map<Student>(student);

                std.update(updated_student);
                return RedirectToAction("Index");
            }

        }
        catch (Exception e)
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
        ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name", data.DepartmentId);
        return View(res);
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult conDelete(int id)
    {
        var data = std.Getbyid(id);
        try
        {
            stdCrs.deleteAllForstudent(id);
            std.delete(id);
            fileUploader.delete(data.imgname, "images");
            return RedirectToAction("Index");

        }
        catch (Exception e)
        {
            var res = mapper.Map<StudentVM>(data);
            return View(res);
        }
    }
}

