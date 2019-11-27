using System.ComponentModel.DataAnnotations;

namespace Dating.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}