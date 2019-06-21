using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCSample3.Models;
using MVCSample3.Lib;

namespace MVCSample3.Controllers
{
    public class MyAuthorizeController : Controller
    {
        public LoginInfo CurrentLoginInfo
        {
            get { return (LoginInfo)Session["CurrentLoginInfo"]; }
            protected set { Session["CurrentLoginInfo"] = value; }
        }

        protected bool IsLogin { get { return Session["CurrentLoginInfo"] != null; } }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!IsLogin)
            {
                filterContext.Result = RedirectToRoute("Default", new { Controller = "Account", Action = "Index" });
            }

            base.OnActionExecuting(filterContext);
        }
    }
}