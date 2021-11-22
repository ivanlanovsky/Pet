using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryBLL.Services;
using LibraryBLL.Dto;

namespace ADOnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITitleService tService;
        public HomeController(ITitleService service)
        {
            this.tService = service;
        }
        public ActionResult Index()
        {
            return View(tService.GetAllTitles());
        }
    }
}
