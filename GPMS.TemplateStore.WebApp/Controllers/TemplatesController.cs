using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GPMS.TemplateStore.WebApp.Controllers
{
    public class TemplatesController : Controller
    {
        public IActionResult Projeto(int id)
        {
            return View();
        }
		
		public IActionResult Comunicacao(int id)
        {
            return View();
        }
		
		public IActionResult Riscos(int id)
        {
            return View();
        }
		
		public IActionResult Testes(int id)
        {
            return View();
        }
		
		public IActionResult Configuracao(int id)
        {
            return View();
        }
		
		public IActionResult Encerramento(int id)
        {
            return View();
        }
    }
}