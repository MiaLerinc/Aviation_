// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AviationBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using AviationBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using AviationBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using AviationBlazorServer.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Countries/AddCountry")]
    public partial class AddCountry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\AddCountry.razor"
       
    public Country Country { get; set; }

protected override async Task OnInitializedAsync()
    {
        Country = new Country();
    }

private async Task AddCountryAsync()
    {
        await _countryService.AddCountryAsync(Country);
        Close();
    }

private void Close()
    {
        _navigationManager.NavigateTo("/Countries");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CountryService _countryService { get; set; }
    }
}
#pragma warning restore 1591
