using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMarket.ViewModels;

namespace WebMarket.Contollers
{
    public class HomeController : Controller
    {
        private readonly List<EmployerView> _employees = new List<EmployerView>
        {
            new EmployerView
            {
                Id=1,
                FirstName = "Иван",
                LastName = "Пузиков",
                Patronymic =  "Александрович",
                Age = 22,
                Male = true
            },
            new EmployerView
            {
                Id = 2,
                FirstName = "Владислав",
                LastName = "Петров",
                Patronymic = "Иванович",
                Age = 35,
                Male = true
            },
            new EmployerView
            {
                Id = 3,
                FirstName = "Анна",
                LastName = "Пукина",
                Patronymic = "Петровна",
                Age = 40,
                Male = false
            },
            new EmployerView
            {
                Id = 4,
                FirstName = "Борис",
                LastName = "Моисеев",
                Patronymic = "Иванович",
                Age = 60,
                //Male = null
            }
        };

        // GET: Home
        public ActionResult Index()
        {
            //return Content("Привет из Контроллера");
           return View(_employees);
        }

        public ActionResult Details(int id)
        {
            //return Content("Привет. Я твой первый контроллер");
            return View(_employees.FirstOrDefault(x => x.Id == id));
        }
    }
}