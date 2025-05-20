
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Trend
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string impact { get; set; }
        [Column("time_to_adopt")]
        public string timeToAdopt { get; set; }
        public byte[]? image { get; set; }
    }
}
