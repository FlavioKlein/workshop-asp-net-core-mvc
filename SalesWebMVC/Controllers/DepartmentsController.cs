using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            /*
            List<Department> listaDepartment = new List<Department>
            {
                new Department { Id = 1, Name = "Financeiro" },
                new Department { Id = 2, Name = "Desenvolvimento" },
                new Department { Id = 3, Name = "Suporte" },
                new Department { Id = 4, Name = "Comercial" },
                new Department { Id = 5, Name = "Implantação" }
            };*/

            List<Department> listaDepartment = new List<Department>();
            listaDepartment.Add(new Department { Id = 1, Name = "Financeiro" });
            listaDepartment.Add(new Department { Id = 2, Name = "Desenvolvimento" });
            listaDepartment.Add(new Department { Id = 3, Name = "Suporte" });
            listaDepartment.Add(new Department { Id = 4, Name = "Comercial" });
            listaDepartment.Add(new Department { Id = 5, Name = "Implantação" });
      
            return View(listaDepartment);
        }
    }
}