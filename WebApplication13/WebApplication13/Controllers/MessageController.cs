using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Send(string sendermail, string message)
        {
            try
            {
              
              await  mailer.sendmail(sendermail, message);

                return RedirectToAction("Index","Home");


            }
            catch (Exception e)
            {
                ViewBag.message = "There is error try again please";
                return RedirectToAction("Index");
            }
        }

    }
}
