using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CmdApi.Models
{
    public class RegisterUsers
    {
        [Required (ErrorMessage = "User name is required")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }
        public string bodyType { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public bool needFreeWeights { get; set; }


    }
}
