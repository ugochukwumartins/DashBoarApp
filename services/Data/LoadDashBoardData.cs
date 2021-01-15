using Dashboard.Models;
using Dashboard.services.Baseresults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.services.Data
{
    public interface ILoadDashBoardData
    {
        Task<List<DashBoardModel>> GetDashbordByResult();
        Task<List<DashBoardModel>> GetDataByGender();
    }
    public class LoadDashBoardData 
    {
        public static async Task<List<DashBoardModel>> GetDashbordByResult()
        {
            try
            {
                var restClient = new DashBoardLoadServiceData<BaseResultModel<DashBoardModel>>();
                var PendingLoan = await restClient.GetMyDataByNumbers();


                List<DashBoardModel> content = PendingLoan?.Results;
                return content;
            }
            catch (Exception e) { throw e; }
        }

        public Task<List<DashBoardModel>> GetDataByGender()
        {
            throw new NotImplementedException();
        }
    }
}
