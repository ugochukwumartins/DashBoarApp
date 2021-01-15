using Dashboard.Models;
using Dashboard.services.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // private readonly ILoadDashBoardData _loadDasBoard;
      public  IEnumerable<DashBoardModel> dashBoardModels;
        public HomeController(ILogger<HomeController> logger)
        {
            
            _logger = logger;
        } 
        [HttpGet]
        public async Task<IEnumerable<DashBoardModel>> GetallData(string Gender)
        {
            dashBoardModels = LoadDashBoardData.GetDashbordByResult().Result.ToList();
            return dashBoardModels.Where(gen=> gen.gender==Gender);
        }
        public IActionResult Index()
        {
            dashBoardModels = LoadDashBoardData.GetDashbordByResult().Result.ToList();
          
            return View(dashBoardModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
