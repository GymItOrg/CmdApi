using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmdApi.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public string bodyType { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public bool needFreeWeights { get; set; }
    }
}
