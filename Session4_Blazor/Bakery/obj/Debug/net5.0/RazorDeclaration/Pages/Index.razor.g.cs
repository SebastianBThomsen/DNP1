// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Bakery.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\_Imports.razor"
using Bakery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\_Imports.razor"
using Bakery.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\Pages\Index.razor"
using Bakery.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\Pages\Index.razor"
using Bakery.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session4_Blazor\Bakery\Pages\Index.razor"
       

    public List<Product> Products { get; set; }

    public Product FeaturedProduct { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Products = ProductsService.Products; //WTF sker der her? :(( - Slutning af 8.1 Setting up the page code guide
        FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
    }

    private void NavigateToComponent(Product p)
    {
        NavigationManager.NavigateTo("order/" + p.Id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductsService { get; set; }
    }
}
#pragma warning restore 1591
