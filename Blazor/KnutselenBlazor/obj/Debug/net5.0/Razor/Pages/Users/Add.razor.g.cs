#pragma checksum "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142d143537cb227fde60b78fb603254044f85208"
// <auto-generated/>
#pragma warning disable 1591
namespace KnutselenBlazor.Pages.Users
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
#nullable restore
#line 2 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Layout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/users/add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Voeg een gebruiker toe</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                  model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                                        OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-row");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group col");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, "<label>Voornaam</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                                    model.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.FirstName = __value, model.FirstName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __Blazor.KnutselenBlazor.Pages.Users.Add.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 14 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                                      () => model.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group col");
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.AddMarkupContent(28, "<label>Achternaam</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                                    model.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.LastName = __value, model.LastName))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __Blazor.KnutselenBlazor.Pages.Users.Add.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 19 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                                      () => model.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-row");
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group col");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.AddMarkupContent(46, "<label>Gebruikersnaam</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                                    model.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Username = __value, model.Username))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __Blazor.KnutselenBlazor.Pages.Users.Add.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 26 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                                      () => model.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group col");
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.AddMarkupContent(60, "<label>Wachtwoord</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "type", "password");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                                    model.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __Blazor.KnutselenBlazor.Pages.Users.Add.TypeInference.CreateValidationMessage_3(__builder2, 68, 69, 
#nullable restore
#line 31 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                                      () => model.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.AddMarkupContent(75, "\r\n        ");
                __builder2.OpenElement(76, "button");
                __builder2.AddAttribute(77, "disabled", 
#nullable restore
#line 35 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
                           loading

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(78, "class", "btn btn-primary");
                __builder2.AddMarkupContent(79, "\r\n");
#nullable restore
#line 36 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
             if (loading) 
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(80, "                <span class=\"spinner-border spinner-border-sm mr-1\"></span>\r\n");
#nullable restore
#line 39 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(81, "            Opslaan\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(83);
                __builder2.AddAttribute(84, "href", "users");
                __builder2.AddAttribute(85, "class", "btn btn-link");
                __builder2.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(87, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Wouter\Desktop\knutsel\KnutselenBlazor\Pages\Users\Add.razor"
       
    private AddUser model = new AddUser();
    private bool loading;

    private async void OnValidSubmit()
    {
        loading = true;
        try
        {
            await AccountService.Register(model);
            AlertService.Success("User added successfully", keepAfterRouteChange: true);
            NavigationManager.NavigateTo("users");
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
    }
}
namespace __Blazor.KnutselenBlazor.Pages.Users.Add
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
