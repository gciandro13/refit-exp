using Demo.Refit.Mvc.Model_Refit;
using Demo.Refit.Mvc.Models;
using Demo.Refit.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Demo.Refit.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly INameAgeService _nameAgeService;
        private readonly IGithubService _githubService;


        public HomeController(ILogger<HomeController> logger, INameAgeService nameAgeService,IGithubService githubService)
        {
            _nameAgeService = nameAgeService;
            _githubService = githubService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult RefitNameAge(string name)
        {
            var resp = _nameAgeService.GetNameAge(name);
            return Json(resp.Result.Age);
        }

        public IActionResult Refit(string msg)
        {
            var resp = _githubService.GetMarkdown(msg != null ? msg : "Prova");
            
            return Json(resp.Result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
