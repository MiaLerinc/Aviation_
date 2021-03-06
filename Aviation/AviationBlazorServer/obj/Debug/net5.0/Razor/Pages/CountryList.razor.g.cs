#pragma checksum "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2d573679a01c56678fe425b20d0aa504637c48c"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Countries")]
    public partial class CountryList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Country List</h3>");
#nullable restore
#line 6 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor"
 if(Countries == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div>Loading...</div>");
#nullable restore
#line 9 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-responsive");
            __builder.OpenElement(4, "thead");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor"
                                                            OpenAddCountryPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "<span class=\"oi oi-plus\"></span>\r\n    Add Country\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.AddMarkupContent(11, "<tr><th>Name</th></tr>");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "tbody");
#nullable restore
#line 23 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor"
 foreach(var country in Countries)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
#nullable restore
#line 26 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor"
__builder.AddContent(16, country.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", "/Countries/EditCountry/" + (
#nullable restore
#line 28 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor"
                                 country.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddMarkupContent(22, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor"
                                                           () => DeleteCountryAsync(country.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Korisnik\Desktop\Mia\Aviation\AviationBlazorServer\Pages\CountryList.razor"
       
    private List<Country> Countries;
    protected override async Task OnInitializedAsync()
    {
        Countries = await _countryService.GetCountries();
    }
    private void OpenAddCountryPage()
    {
        _navigationManager.NavigateTo("/Countries/AddCountry");
    }
    private async Task DeleteCountryAsync(int countryId)
    {
        await _countryService.DeleteCountryAsync(countryId);
        Countries = await _countryService.GetCountries();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CountryService _countryService { get; set; }
    }
}
#pragma warning restore 1591
