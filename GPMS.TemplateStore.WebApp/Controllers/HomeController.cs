using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GPMS.TemplateStore.Logic.Templates;
using Microsoft.AspNetCore.Mvc;
using GPMS.TemplateStore.WebApp.Models;

namespace GPMS.TemplateStore.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TemplateMockRepository _repository = new TemplateMockRepository();
        
        public IActionResult Index()
        {
            return View(_repository.GetTemplateList(null));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
