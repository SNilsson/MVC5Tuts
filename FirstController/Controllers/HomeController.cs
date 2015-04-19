using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string id)
        {
            return "<b>The value of the ID is: <b>" + id;
        }
    }
}