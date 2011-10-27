using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ILoveAOP.Services;

namespace ILoveAOP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRandomNumberService _randomNumberService;

        public HomeController(IRandomNumberService randomNumberService)
        {
            _randomNumberService = randomNumberService;
        }

        public ActionResult Index()
        {
            SecurityContext.Roles = new [] { "Admin" };
            var number = _randomNumberService.Get();
            return Content(number.ToString());
        }

    }
}
