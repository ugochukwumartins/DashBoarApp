using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Models.Dashbord
{
    public class Location
    {
        public Street street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public Coordinates coordinates { get; set; }
        public Timezone timezone { get; set; }
    }
    public class Street
    {
        public int number;
        public string name;
        public int  Number { get=>number; set=>number=value; }
       public string  Name { get=>name; set=>name=value; }
       public string fulladdress { get => number + " " + name; }
    }
}
