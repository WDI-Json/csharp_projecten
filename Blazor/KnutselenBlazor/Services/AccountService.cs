using KnutselenBlazor.Models;
using KnutselenBlazor.Models.Account;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KnutselenBlazor.Services
{
/*
The account service handles communication between the Blazor app and the backend api for everything related to user accounts. 
It contains methods for the login, logout and registration, as well as and standard CRUD methods for retrieving and modifying user data.
On successful login the User property is set to the value returned from the api, and the user object is stored in browser local storage to keep the user logged in between page refreshes and browser sessions.
If you prefer not to use local storage you can simply remove references to the local storage service from the account service and the application will continue to work correctly, except for the "stay logged in" feature.
The User property provides access to the currently logged in user to any other component, for example the main layout component uses it to show/hide the main navigation bar and set a css class on the app container div.
The Initialize() method is called from Program.cs on startup to assign the "user" object from local storage to the User property, which enables the user to stay logged in between page refreshes and browser sessions. 
This couldn't be put into the constructor because getting data from local storage is an async action.
*/


    public interface IAccountService
    {
        User User { get; }
        Task Initialize();
        Task Login(Login model);
        Task Logout();
        Task Register(AddUser model);
        Task<IList<User>> GetAll();
        Task<User> GetById(string id);
        Task Update(string id, EditUser model);
        Task Delete(string id);
    }

    public class AccountService : IAccountService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private string _userKey = "user";

        public User User { get; private set; }

        public AccountService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService
        ) {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            User = await _localStorageService.GetItem<User>(_userKey);
        }

        public async Task Login(Login model)
        {
            User = await _httpService.Post<User>("/users/authenticate", model);
            await _localStorageService.SetItem(_userKey, User);
        }

        public async Task Logout()
        {
            User = null;
            await _localStorageService.RemoveItem(_userKey);
            _navigationManager.NavigateTo("account/login");
        }

        public async Task Register(AddUser model)
        {
            await _httpService.Post("/users/register", model);
        }

        public async Task<IList<User>> GetAll()
        {
            return await _httpService.Get<IList<User>>("/users");
        }

        public async Task<User> GetById(string id)
        {
            return await _httpService.Get<User>($"/users/{id}");
        }

        public async Task Update(string id, EditUser model)
        {
            await _httpService.Put($"/users/{id}", model);

            // update stored user if the logged in user updated their own record
            if (id == User.Id) 
            {
                // update local storage
                User.FirstName = model.FirstName;
                User.LastName = model.LastName;
                User.Username = model.Username;
                await _localStorageService.SetItem(_userKey, User);
            }
        }

        public async Task Delete(string id)
        {
            await _httpService.Delete($"/users/{id}");

            // auto logout if the logged in user deleted their own record
            if (id == User.Id)
                await Logout();
        }
    }
}