using System.ComponentModel.DataAnnotations;

namespace WeatherApplication.Models
{
    public class LoginModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field is requierd!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field is requierd!")]
        public string Password { get; set; }
    }
}
