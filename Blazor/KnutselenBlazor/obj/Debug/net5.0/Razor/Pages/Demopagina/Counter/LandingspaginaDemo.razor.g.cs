#pragma checksum "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\Pages\Demopagina\Counter\LandingspaginaDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993f45eef020617ac4e04db0fabae5a0ac8edcf3"
// <auto-generated/>
#pragma warning disable 1591
namespace KnutselenBlazor.Pages.Demopagina.Counter
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Demopagina/counter")]
    public partial class LandingspaginaDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Teller</h1>\r\n  ");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "De huidige waarde is: ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\Pages\Demopagina\Counter\LandingspaginaDemo.razor"
                            currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n  ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\Pages\Demopagina\Counter\LandingspaginaDemo.razor"
                                           IncrementCounter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Optellen");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n  ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\Pages\Demopagina\Counter\LandingspaginaDemo.razor"
                                           ResetToZero

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Reset");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\Pages\Demopagina\Counter\LandingspaginaDemo.razor"
       
  private int currentCount = 42;
  private void IncrementCounter()
  {
    currentCount++;
  }
    private void ResetToZero()
  {
    currentCount = 0;
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
