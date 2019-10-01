using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVC.Controllers
{
    public class GreetController : Controller
    {
        public ViewResult Index(string name)
        {
            var model = new GreetingModel();
            return View(model);
        }
    }
}
