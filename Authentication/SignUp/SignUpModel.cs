using System.ComponentModel.DataAnnotations;

namespace Beceps.Authentication.SignUp
{
    public class SignUpModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public void Reset()
        {
            Email = "";
            Password = "";
        }
    }
}
