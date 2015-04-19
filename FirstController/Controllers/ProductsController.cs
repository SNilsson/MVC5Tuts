using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstController.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : Controller
    {
        // GET: Product

        public string Index()
        {
            return "this is all the products";
        }

        [Route("{catagory}")]
        public string showCatagory(string products){
            return "This is the list of products within the catagory";
        }
         [Route("{catagory?}/{id:int}")]
        public string details(string catagory, string id){
            return "This is the details about the certain product with ID: " + id;
        }
        [Route("~/for-sale/{catagory?}")]
        public string foo(string id)
        {
            return "this is a method action " + id;
        }
    }
}