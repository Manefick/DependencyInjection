using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;//где именно при вызове интерфейса создаеться екземпляр класса реализуещего интерфейс?
        private ProductTotalizer totalizator;// зачем мы создаем екземпляр а не используем тот что передается в конструкторе
        public HomeController(IRepository repo, ProductTotalizer total)
        {
            repository = repo;  //зачем и как оно работает
            totalizator = total;
        }
        //public ViewResult Index() => View(repository.Products);//откуда беруться даніе из интерфейса ??
        public ViewResult Index()
        {
            ViewBag.Total = totalizator.Total;
            return View(repository.Products);
        }
    }
}
