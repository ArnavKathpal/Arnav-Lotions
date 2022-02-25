using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arnav_Lotions.Models
{
    public class Lotion
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Type  { get; set; }
        public decimal Quantity { get; set; }
        public string Fragnance { get; set; }
        public string Ingredients { get; set; }
        public int Rating { get; set; }
    }
}
