using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcceptanceCommission.Models;

namespace AcceptanceCommission.Controllers
{
    public class HomeController : Controller
    {
        AScontext db = new AScontext();

        public ActionResult Index()
        {
            
            return View(db.Students);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}