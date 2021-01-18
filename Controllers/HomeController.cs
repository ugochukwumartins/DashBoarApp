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
        public IActionResult AllDataBy(string button)
        {
            try
            {
                if (button == "All")
                {
                    TempData["buttonval"] = "ALL USERS";
                     dashBoardModels = LoadDashBoardData.GetDashbordByResult().Result.ToList();
                    // var Data = dashBoardModels.Where(gen => gen.gender == button);
                }
                else if (button == "Male")
                {
                    TempData["buttonval"] = "Male USERS";
                     dashBoardModels = LoadDashBoardData.GetDataByGenderFemale().Result.ToList();
                   
                }
                else
                {
                    TempData["buttonval"] = "Female USERS";
                    dashBoardModels = LoadDashBoardData.GetDataByGenderFemale().Result.ToList();


                }
                // dashBoardModels = LoadDashBoardData.GetDashbordByResult().Result.ToList();
                // var Data = dashBoardModels.Where(gen => gen.gender == button);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public IActionResult Index()
        {
            try
            {
               
                dashBoardModels = LoadDashBoardData.GetDashbordByResult().Result.ToList();

                return View(dashBoardModels);
            }
            catch (Exception)
            {

                throw;
            }
           
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
