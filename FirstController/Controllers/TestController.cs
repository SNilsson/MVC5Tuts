using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string Index()
        {
            return "Test is runnign now";
        }
    }
}