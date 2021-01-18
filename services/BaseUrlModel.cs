using System.Text.Json.Serialization;

namespace Dashboard.services
{
    public class BaseUrlModel
    {
        public string link { get; set; }

        [JsonIgnore]
        public string Geturl
        {
            //get { string address = "https://randomuser.me/api/?results=10&gender=female"; link = address;  return $"{link}"; }
            get { string address = "https://randomuser.me/api/?results=50"; link = address; return $"{link}"; }
            //   get { string address = "https://randomuser.me/api/?results=10&gender=male"; link = address;  return $"{link}"; }

        }
        public string GeturlMale
        {
            //get { string address = "https://randomuser.me/api/?results=10&gender=female"; link = address;  return $"{link}"; }
           // get { string address = "https://randomuser.me/api/?results=50"; link = address; return $"{link}"; }
               get { string address = "https://randomuser.me/api/?results=50&gender=male"; link = address;  return $"{link}"; }

        }
        public string GeturlFemale
        {
            get { string address = "https://randomuser.me/api/?results=50&gender=female"; link = address;  return $"{link}"; }
          //  get { string address = "https://randomuser.me/api/?results=50"; link = address; return $"{link}"; }
            //   get { string address = "https://randomuser.me/api/?results=50&gender=male"; link = address;  return $"{link}"; }

        }


    }
}
