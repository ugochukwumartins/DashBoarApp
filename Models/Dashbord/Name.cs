using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Models.Dashbord
{
    public class Name
    {
        public string title;
        public string first;
        public string last;
        public string Title { get=>title; set=>title=value; }
            public string First { get=>first; set=>first=value; }
            public string Last { get=>last; set=>last=value; }
        public string fullname  { get=> title +" "+ first + " "+ last;  }

    }
}
