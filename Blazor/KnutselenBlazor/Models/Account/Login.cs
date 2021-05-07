using System.ComponentModel.DataAnnotations;

/*
The login model represents the data and validation rules for logging into the Blazor app. 
The model is bound to the login form which uses it to pass form data to the AccountService.Login() method.
*/
namespace KnutselenBlazor.Models.Account
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}