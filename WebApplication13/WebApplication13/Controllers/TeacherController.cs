using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using WebApplication13.BL;
using WebApplication13.BL.services;
using WebApplication13.BL.VM;
using WebApplication13.DAL.Entities;

namespace WebApplication13.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacher teacher;
        private readonly IMapper mapper;
        private readonly IDepartment dept;

        public TeacherController(ITeacher teacher, IMapper mapper,IDepartment dept)
        {
            this.teacher = teacher;
            this.mapper = mapper;
            this.dept = dept;
        }
        public IActionResult Index()
        {   var data=teacher.GetAll();  
            var res=mapper.Map<IEnumerable<TeacherVM>>(data);
            return View(res);
        }

        public IActionResult Create()
        {
            ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
            return View();  
        }
        [HttpPost]
        public IActionResult Create(TeacherVM tech)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var imgname = fileUploader.upload("images", tech.img);
                    var cvname= fileUploader.upload("files", tech.cv);
                    var data = mapper.Map<Teacher>(tech);
                    data.imgname = imgname;
                    data.Cvname = cvname;
                    teacher.create(data);
                    return RedirectToAction("Index");
                }
                ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
                return View(tech);
            }
            catch(Exception e)
            {
                ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
                return View(tech);
            }
        }


        public IActionResult update(int id)
        {
            var data = teacher.Getbyid(id);
            var res=mapper.Map<TeacherVM>(data);
            ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
            return View(res);
        }
        [HttpPost]
        public IActionResult update(TeacherVM tech,string oldimg,string oldcv)
        {
            string newimg = "";
            string newcv = "";
            try
            { 
                if (ModelState.IsValid)
                {
                    if (tech.img == null)
                    {
                        tech.imgname= oldimg;
                    }
                    else
                    {
                      newimg=fileUploader.upload("images", tech.img);
                     fileUploader.delete("images",oldimg);
                        tech.imgname= newimg;
                    }




                    if (tech.cv == null)
                    {
                        tech.Cvname = oldcv;
                    }
                    else
                    {
                        newcv = fileUploader.upload("images", tech.img);
                        fileUploader.delete("files", oldcv);
                        tech.Cvname= newcv; 
                    }


                    var data = mapper.Map<Teacher>(tech);
                    teacher.update(data);
                    return RedirectToAction("Index");
                }
                tech.imgname= oldimg;
                tech.Cvname = oldcv;
                ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
                return View(tech);

            }
            catch (Exception e)
            {
                ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
                tech.imgname = oldimg;
                tech.Cvname = oldcv;
                return View(tech);
            }
        }


        public IActionResult Details(int id)
        {
            ViewBag.departments = new SelectList(dept.GetAll(), "DepartmentId", "Name");
            var data = teacher.Getbyid(id);
            var res = mapper.Map<TeacherVM>(data);
            return View(res);

        }



        public IActionResult Delete(int id)
        {
            var data = teacher.Getbyid(id);
            var res = mapper.Map<TeacherVM>(data);
            return View(res);

        }


        [ActionName("Delete")]
        [HttpPost]
        public IActionResult ConDelete(int id)
        {
            try
            {
           
                teacher.delete(id);
                return RedirectToAction("Index");
            }catch (Exception e)
            {
                return View();
            }
            

        }

        public MemoryStream down(string filename)
        {
            var path = Directory.GetCurrentDirectory() + "/wwwroot/files/" + filename + "";
            var memory = new MemoryStream();
            var net = new System.Net.WebClient();
            var data = net.DownloadData(path);
            var content = new MemoryStream(data);
            memory = content;

            memory.Position = 0;
            return memory;
        }
        public IActionResult Download(string filename)
        {
            var mem=down(filename);
            return File(mem.ToArray(), "application/pdf", filename);


           
        }
    }
}
