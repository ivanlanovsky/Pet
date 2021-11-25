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
    public class TitleController : Controller
    {
        private readonly ITitleService tService;
        public TitleController(ITitleService service)
        {
            this.tService = service;
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            TitleViewModel title = tService.GetById(id);
            if (title == null)
                return View("NotFound");
            return View(title);
        }
    }
}
