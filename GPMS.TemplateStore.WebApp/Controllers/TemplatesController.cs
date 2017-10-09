using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GPMS.TemplateStore.Logic.Templates;
using Microsoft.AspNetCore.Mvc;

namespace GPMS.TemplateStore.WebApp.Controllers
{
    public class TemplatesController : Controller
    {
        private readonly TemplateMockRepository _repository = new TemplateMockRepository();
        
        public IActionResult Details(long id)
        {
            return View(_repository.GetById(id));
        }
		
    }
}