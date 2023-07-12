



namespace WebApplication13.Controllers;

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
        public async Task<IActionResult> Index(string recieveremail, string message)
        {
            try
            {
              
              var x=  mailer.sendmail(recieveremail, message);

            if (x)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
       TempData["message"] = "There is error try again please";
                return RedirectToAction("Index");
            }
                


            }
            catch (Exception e)
            {
            TempData["message"] = "There is error try again please";

            return RedirectToAction("Index");
            }
        }

    }

