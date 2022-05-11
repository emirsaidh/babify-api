using System.ComponentModel.DataAnnotations;

namespace babify_api.Models.ViewModel

{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        [StringLength(15, ErrorMessage = "Your username must be beetween 5-15 charachters length", MinimumLength = 4)]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "It doesn't seems like an email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password, ErrorMessage = "Please refer to password requirements")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
