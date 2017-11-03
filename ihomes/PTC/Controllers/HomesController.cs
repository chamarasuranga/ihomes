using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTC.Controllers
{
    public class HomesController : Controller
    {

        public ActionResult AddHome()
        {
            return View();
        }

        // GET: Homes
        public ActionResult Index()
        {
            return View();
        }
    }
}