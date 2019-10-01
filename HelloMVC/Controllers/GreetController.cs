using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVC.Controllers
{
    public class GreetController
    {
        public ViewResult Index(string name)
        {
            return View();
        }
    }
}
