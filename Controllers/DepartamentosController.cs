using Microsoft.AspNetCore.Mvc;
using MVC2.Models.ViewModel;
using System.Collections.Generic;

namespace MVC2.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()

        {
            List<Departamento> departamentos = new List<Departamento>();
            departamentos.Add(new Departamento { Id = 1,Name = "Games"});
            departamentos.Add(new Departamento { Id = 2, Name = "consoles" });
            return View();
        }
    }
}
