using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumingAPIs.Models
{
    //What is this magic? 
    //Copy your JSON, go to edit->Paste Special
    //and then Paste JSON as classes
    //Then you can rename if you want to

    public class Rootobject
    {
        public Fact[] all { get; set; }
    }

    public class Fact
    {
        public string _id { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public User user { get; set; }
        public int upvotes { get; set; }
        public object userUpvoted { get; set; }
    }

    public class User
    {
        public string _id { get; set; }
        public Name name { get; set; }
    }

    public class Name
    {
        public string first { get; set; }
        public string last { get; set; }
    }

}
