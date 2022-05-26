﻿using System.ComponentModel.DataAnnotations;

namespace DesafioSoftplan.Services.Dtos
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}