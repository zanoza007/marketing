using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Project.Models
{
    public class User : IdentityUser
    {
  
        public string name { get; set; }
        public string password { get; set; }
        public override string Email { get; set; }
        public int telephone { get; set; }
    }
}
