// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KnutselenBlazor.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Layout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Account\Register.razor"
       
    private AddUser model = new AddUser();
    private bool loading;

    private async void OnValidSubmit()
    {
        // reset alerts on submit
        AlertService.Clear();
        
        loading = true;
        try
        {
            await AccountService.Register(model);
            AlertService.Success("Registration successful", keepAfterRouteChange: true);
            NavigationManager.NavigateTo("account/login");
        }
        catch (Exception ex)
        {
            AlertService.Error(ex.Message);
            loading = false;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
#pragma warning restore 1591
