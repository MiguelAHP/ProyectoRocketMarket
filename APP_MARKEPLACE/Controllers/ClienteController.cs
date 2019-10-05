using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using APP_MARKEPLACE.Entity;
using APP_MARKEPLACE.Models;
using APP_MARKEPLACE.SQLServer;

namespace APP_MARKEPLACE.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
    }
}