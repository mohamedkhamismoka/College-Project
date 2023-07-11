using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using WebApplication13.BL;
using WebApplication13.BL.VM;
using WebApplication13.DAL.Entities;

namespace WebApplication13.Controllers;

    public class PaymentController : Controller
    {
        private readonly IMapper mapper;
        private readonly IPayment pay;
        private readonly IStudent std;

        public PaymentController(IMapper mapper, IPayment pay, IStudent std)
        {
            this.mapper = mapper;
            this.pay = pay;
            this.std = std;
        }
        public IActionResult Create()
        {
            ViewBag.students = new SelectList(std.GetAll(), "StudentId", "StudentId");

            return View();
        }

        [HttpPost]
        public IActionResult Create(paymentVM pays)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Payment>(pays);
                    pay.create(data);
                    return RedirectToAction("Index", "Home");
                }
                return View(pays);
            }
            catch (Exception e)
            {
                return View(pays);
            }

        }

        public IActionResult Gate()
        {
            return View();
        }

        public IActionResult Details(int payid)
        {

            var data = pay.Getbyid(payid);
            if (data != null)
            {
                var res = mapper.Map<paymentVM>(data);
                return View(res);
            }
            else
            {
                TempData["error"] = "Please,enter valid Payment ID";
                return RedirectToAction("Gate");
            }





        }


        public IActionResult update(int payid)
        {

            var data = pay.Getbyid(payid);
            if (data != null)
            {
                var res = mapper.Map<paymentVM>(data);

                ViewBag.students = new SelectList(std.GetAll(), "StudentId", "StudentId");
                return View(res);
            }
            else
            {
                TempData["error"] = "Please,enter valid Payment ID";
                return RedirectToAction("Gate");
            }





        }


        [HttpPost]
        public IActionResult update(paymentVM pays)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var res = mapper.Map<Payment>(pays);
                    pay.update(res);
                    return RedirectToAction("Gate");


                }

                ViewBag.students = new SelectList(std.GetAll(), "StudentId", "StudentId");
                return View(pays);


            }
            catch (Exception ex)
            {
                ViewBag.students = new SelectList(std.GetAll(), "StudentId", "StudentId");
                return View(pays);
            }



        }
    }

