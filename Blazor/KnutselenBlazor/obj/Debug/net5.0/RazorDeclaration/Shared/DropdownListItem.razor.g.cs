// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KnutselenBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using KnutselenBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\Shared\DropdownListItem.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class DropdownListItem<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "c:\Users\Wouter\Documents\GitHub\csharp_projecten\Blazor\KnutselenBlazor\Shared\DropdownListItem.razor"
       
    [CascadingParameter(Name="Dropdown")]
    public Dropdown<TItem> Dropdown {get;set;}

    [Parameter]
    public TItem Item{get;set;}
    [Parameter]
    public RenderFragment<TItem> ChildContent {get;set;}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
