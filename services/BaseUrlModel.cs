using System.Text.Json.Serialization;

namespace Dashboard.services
{
    public class BaseUrlModel
    {
        public string link { get; set; }

        [JsonIgnore]
        public string Geturl
        {
            //get { string address = "https://apidevelopment.xceed365.com/api/"; link = address;  return $"{link}"; }
            get { string address = "https://randomuser.me/api/?results=50"; link = address; return $"{link}"; }
            //   get { string address = "https://apistaging.xceed365.com/api/"; link = address;  return $"{link}"; }

        }


    }
}
