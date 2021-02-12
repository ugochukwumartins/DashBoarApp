using Dashboard.Models;
using Dashboard.Models.Dashbord;
using Dashboard.Pagination;
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
        public IEnumerable<DashBoardModel> dashBoardModels;
        ViewModel ViewModels = new ViewModel();
        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }
        
        public IActionResult Index(string button, int pageNum = 1)
        {
            try
            {
                if (button == "All")
                {
                    TempData["buttonval"] = "ALL USERS";
                    dashBoardModels = LoadDashBoardData.GetDashbordByResult().Result.ToList();
                    ViewModels.dashBoardModels = PaginationLists<DashBoardModel>.CreatePaginationAsync(LoadDashBoardData.dashBoardModels, pageNum, 5);
                    ViewModels.pagination = PaginationLists<DashBoardModel>.CreatePaginationAsyncs(LoadDashBoardData.dashBoardModels, pageNum, 5);
                    return View(ViewModels);
                }
                else if (button == "Male")
                {
                    TempData["buttonval"] = "Male USERS";
                    dashBoardModels = LoadDashBoardData.GetDataByGenderMale().Result.ToList();
                    ViewModels.dashBoardModels = PaginationLists<DashBoardModel>.CreatePaginationAsync(LoadDashBoardData.MaledashBoardModels, pageNum, 5);
                    ViewModels.pagination = PaginationLists<DashBoardModel>.CreatePaginationAsyncs(LoadDashBoardData.MaledashBoardModels, pageNum, 5);
                    return View(ViewModels);

                }
                else if (button == "Female")
                {
                    TempData["buttonval"] = "Female USERS";
                    dashBoardModels = LoadDashBoardData.GetDataByGenderFemale().Result.ToList();
                    ViewModels.dashBoardModels = PaginationLists<DashBoardModel>.CreatePaginationAsync(LoadDashBoardData.FemalehBoardModels, pageNum, 5);
                    ViewModels.pagination = PaginationLists<DashBoardModel>.CreatePaginationAsyncs(LoadDashBoardData.FemalehBoardModels, pageNum, 5);
                    return View(ViewModels);

                }
                TempData["buttonval"] = "ALL USERS";
                LoadDashBoardData.GetDashbordByResult().Result.ToList();
                var d = LoadDashBoardData.dashBoardModels;


                ViewModels.dashBoardModels = PaginationLists<DashBoardModel>.CreatePaginationAsync(LoadDashBoardData.dashBoardModels, pageNum, 5);
                ViewModels.pagination = PaginationLists<DashBoardModel>.CreatePaginationAsyncs(LoadDashBoardData.dashBoardModels, pageNum, 5);
                return View(ViewModels);

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
