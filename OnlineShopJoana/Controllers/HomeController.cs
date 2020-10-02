using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using OnlineShopJoana.Models;
using OnlineShopJoana.WEB.Helpers;
using OnlineShopJoana.WEB.Models;

using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace OnlineShopJoana.WEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMailHelper _mailHelper;
        private readonly IUserHelper _userHelper;

        public HomeController(IMailHelper mailHelper,
            IUserHelper userHelper)
        {
            _mailHelper = mailHelper;
            _userHelper = userHelper;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    _mailHelper.SendMail("joanatpsi@gmail.com", model.Subject, $"Mail from: {model.Name}, {model.Email}</br>" +
                                        $"</br></br>Message: {model.Message}");

                    ViewBag.Message = String.Format("The message was successfully delivered !!", model, DateTime.Now.ToString());

                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }

            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("error/404")]
        public IActionResult Error404()
        {
            return View();
        }
    }
}
