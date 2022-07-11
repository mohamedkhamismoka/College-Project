using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Mail;
using WebApplication13.BL;

namespace WebApplication13.Controllers
{
    public class MessageController : Controller
    {
        private readonly Mailsender mailer;
        public MessageController(Mailsender mailer)
        {
            this.mailer = mailer;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Send(string sendermail, string senderpass, string recievermail, string message)
        {
            try
            {
              

                mailer.sendmail(sendermail,recievermail, senderpass,"Hello", message);
                return RedirectToAction("Index");


            }
            catch (Exception e)
            {
                ViewBag.message = "There is error try again please";
                return RedirectToAction("Index");
            }
        }

    }
}
