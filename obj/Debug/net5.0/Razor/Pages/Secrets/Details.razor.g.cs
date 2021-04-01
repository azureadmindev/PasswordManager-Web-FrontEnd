#pragma checksum "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fc94009d966a51230f980de62f4c47b5647eeae"
// <auto-generated/>
#pragma warning disable 1591
namespace keyvault.Pages.Secrets
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using keyvault;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using keyvault.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Details.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Details.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Details.razor"
using web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Details.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/secrets/details/{id}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Blazor is ");
            __builder.AddContent(2, 
#nullable restore
#line 9 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Details.razor"
               id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, "!");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Details.razor"
       
    [Parameter]
    public string id { get; set; }

    private SecretDetailsViewModel secretModel;
    protected override async Task OnInitializedAsync()
    {
        try 
        {
            secretModel = await _secretService.Get(id);
        }
        catch(AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
        catch(Exception e)
        {
            throw e;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private keyvault.web.services.SecretService _secretService { get; set; }
    }
}
#pragma warning restore 1591
