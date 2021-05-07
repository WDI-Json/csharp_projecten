using System.ComponentModel.DataAnnotations;

/*The edit user model represents the data and validation rules for updating an existing user account. 
The model is bound to the edit user form which uses it to pass form data to the AccountService.Update() method.*/
namespace KnutselenBlazor.Models.Account
{
    public class EditUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string Password { get; set; }

        public EditUser() { }

        public EditUser(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
        }
    }
}