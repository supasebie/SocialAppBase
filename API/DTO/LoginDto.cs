using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class LoginDto
    {
        [Required]
        public string UserName { get; set; } = "error"!;
        [Required]
        public string Password { get; set; } = "error"!;
    }
}