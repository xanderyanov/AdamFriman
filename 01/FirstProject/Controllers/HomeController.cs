using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FirstProject.Controllers
{

    

    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            //string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";

            Person people = new Person
            {
                name = "John",
                age = 25,
            };

            return View("MyView", people);

        }

        
    }
}
