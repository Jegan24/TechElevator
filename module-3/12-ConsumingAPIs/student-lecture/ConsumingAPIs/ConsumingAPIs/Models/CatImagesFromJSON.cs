using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumingAPIs.Models
{
    public class CatImagesFromJSON
    {
    }

    public class ImagesRoot
    {
        public PicInfo[] Property1 { get; set; }
    }

    public class PicInfo
    {
        public object[] breeds { get; set; }
        public Category[] categories { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }

}