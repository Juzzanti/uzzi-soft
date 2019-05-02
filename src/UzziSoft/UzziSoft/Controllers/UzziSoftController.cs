using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UzziSoft.Controllers
{
    public class UzziSoftController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult()
            {
                Content = "Hello from UzziSoft!"
            };
            
        }
    }
}