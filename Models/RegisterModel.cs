using System.ComponentModel.DataAnnotations;

namespace WeatherApplication.Models
{
    public class RegisterModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Surname is required!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "The field Email is required!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "The field Repeat pass is required!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords not the same")]
        public string RepeatPassword { get; set; }
    }
}
