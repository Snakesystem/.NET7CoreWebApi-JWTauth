using System.ComponentModel.DataAnnotations;

namespace AuthNet7WebApi.Core.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Username is Required")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string? Password { get; set; }
    }
}
