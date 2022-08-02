using DummyApiExample.Helpers;
using DummyApiExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyApiExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(DummiesHelper.GetUserList());
        }
        public ActionResult Detail(string id)
        {
            return View(DummiesHelper.GetUserFull(id));
        }


    }
}