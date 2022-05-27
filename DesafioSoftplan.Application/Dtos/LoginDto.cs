using System.ComponentModel.DataAnnotations;

namespace DesafioSoftplan.Services.Dtos
{
    public class LoginDto
    {
        public LoginDto()
        { }
        public LoginDto(string email, string password)
        {
            Email = email;
            Password = password;
        }
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}