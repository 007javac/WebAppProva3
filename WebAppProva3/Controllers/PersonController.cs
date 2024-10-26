using WebAppProva3.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAppProva3.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonModel _person;
        public PersonController()
        {
            _person = new PersonModel
            {
                FirstName = "Юрий",
                LastName = "Карамышев",
                GroupNumber = "csharp-pro-04102024",
                AboutMe = "Изучаю программирование на C#.",
                Photo = "/images/avafoto.jpg",
                Hobby = "Программирование, чтение технической литературы, спорт."
            };
        }

        public IActionResult About()
        {
            return View(_person);
        }

        public IActionResult Index()
        {
            return RedirectToAction("About");
        }

        public IActionResult Hobby()
        {
            return View(_person);
        }
    }
}