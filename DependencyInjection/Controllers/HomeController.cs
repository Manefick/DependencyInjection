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
        public HomeController(IRepository repo) => repository = repo;//зачем и как оно работает
        public ViewResult Index() => View(repository.Products);//откуда беруться даніе из интерфейса ??
    }
}
