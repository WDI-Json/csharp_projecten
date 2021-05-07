using System.ComponentModel.DataAnnotations;

/*
The add user model represents the data and validation rules for registering or adding a new user. 
The model is bound to the register form and add user form, which use it to pass form data to the AccountService.Register() method to create new user accounts.
*/
namespace KnutselenBlazor.Models.Account
{
    public class AddUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string Password { get; set; }
    }
}