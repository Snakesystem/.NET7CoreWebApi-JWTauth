using System.ComponentModel.DataAnnotations;

namespace AuthNet7WebApi.Core.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "Username is Required")]
        public string UserName { get; set; }
    }
}
