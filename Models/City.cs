using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoApi.Models
{
    public class City
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string latitude { get; set; }
        public string length { get; set; }
    }
}
