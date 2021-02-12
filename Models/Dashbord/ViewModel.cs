using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Models.Dashbord
{
    public class ViewModel
    {
        public IEnumerable<DashBoardModel> dashBoardModels { get; set; }
        public PaginationLists<DashBoardModel>  pagination { get; set; }
    }
}
