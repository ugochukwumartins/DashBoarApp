using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dashboard.services
{
    public class Dashboardservices<T>
    {
       
        public async Task<T> GenericGet(string url)
        {
            try
            {

                var handler = new HttpClientHandler();
                var client = new HttpClient(handler);
                // client.Timeout = TimeSpan.FromSeconds(12200);
               // client.Timeout = TimeSpan.FromMinutes(120);
                var requestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(url)
                };



                // requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Settings.AccessToken);

                var response = await client.SendAsync(requestMessage);

                // var connection =  response.StatusCode;
                if (response.IsSuccessStatusCode == true)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    T resultModel = JsonConvert.DeserializeObject<T>(content);
                    return resultModel;
                }
                else
                {
                    return default;
                }



            
            }
            catch (Exception e)
            {
                var m = e.ToString();
                //await Application.Current.MainPage.DisplayAlert("Server Error", m + ",There has been an server error. Please try later.", "OK");
               // ErrorHelper.Track(e);
                throw;
            }
        }
        }
}
