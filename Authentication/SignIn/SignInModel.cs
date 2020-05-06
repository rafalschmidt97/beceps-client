using System.ComponentModel.DataAnnotations;

namespace Beceps.Authentication.SignIn
{
    public class SignInModel
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
