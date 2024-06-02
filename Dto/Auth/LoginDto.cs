﻿using System.ComponentModel.DataAnnotations;

namespace BbCenter.Dto.Auth
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
