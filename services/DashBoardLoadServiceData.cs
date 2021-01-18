﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.services
{
    public class DashBoardLoadServiceData<T> : Dashboardservices<T>
    {
        BaseUrlModel baseUrl = new BaseUrlModel();
        public async Task<T> GetMyDataByNumbers()
        {
            string url = baseUrl.Geturl;

            try
            {
                return await GenericGet(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<T> GetMyDataByGenderMale()
        {
            
            string url = baseUrl.GeturlMale;

            try
            {
                return await GenericGet(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<T> GetMyDataByGenderFemale()
        {
          
            string url = baseUrl.GeturlFemale;

            try
            {
                return await GenericGet(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
