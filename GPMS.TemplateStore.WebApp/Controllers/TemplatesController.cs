using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GPMS.TemplateStore.WebApp.Controllers
{
    public class TemplatesController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}