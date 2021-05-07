using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmdApi.Models
{
    public class Places
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int Rate { get; set; }
        public string CatersTo { get; set; }

    }
}
