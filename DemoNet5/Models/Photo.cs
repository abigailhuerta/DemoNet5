using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoNet5.Models
{
    public class Photo
    {
        public int id { get; set; }
        public string author { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
        public string download_url { get; set; }
    }
}
