using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCSample3.Models;

namespace MVCSample3.Controllers
{
    public class MenuController : Controller
    {
        public ActionResult GetMenu()
        {
            return PartialView("_MenuPartial", new MenuDataCollection());
        }
    }
}