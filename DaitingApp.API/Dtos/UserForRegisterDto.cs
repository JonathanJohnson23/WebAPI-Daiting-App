using System.ComponentModel.DataAnnotations;

namespace DaitingApp.API.Dtos
{
    public class UserForRegisterDto
    {   
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "YO MUST BE BE TWEEN 4 N 8  ")]
        public string Password { get; set; }
    
    }
}