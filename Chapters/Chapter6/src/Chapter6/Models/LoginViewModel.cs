using System.ComponentModel.DataAnnotations;

namespace Chapter6.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
