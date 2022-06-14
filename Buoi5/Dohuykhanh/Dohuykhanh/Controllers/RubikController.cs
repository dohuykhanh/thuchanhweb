using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dohuykhanh.App_Start;

namespace Dohuykhanh.Controllers
{
    public class RubikController : Controller
    {
        Rubiks data = new Rubiks();
        // GET: Rubik
        public ActionResult Index()
        {
            var all_Rubik = from s in data.Rubik select s;
            return View(all_Rubik);
        }
    }
}