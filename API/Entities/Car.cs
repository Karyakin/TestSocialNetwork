using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Car
    {
        public long Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
    }
}
