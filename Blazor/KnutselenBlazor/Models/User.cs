namespace KnutselenBlazor.Models
{
    /*
The user model defines the properties of a user account, it's used by the account service for handling user data returned from the api, 
and other parts of the application for passing user data around.

The IsDeleting property is used by the users home page to show a spinner while a user account is deleting.
*/
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public bool IsDeleting { get; set; }
    }
}