// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace bussemand
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\_Imports.razor"
using Ex1_SimpleSetup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\_Imports.razor"
using Ex1_SimpleSetup.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\Pages\Login.razor"
using global::Data.CustomAuthentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Bruger\Desktop\VIA\SoftwareEngineer\3. Semester\DNP\DNP1\Session5_Blazor_Login\Ex1_SimpleSetup\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout()
    {
        errorMessage = "";
        username = "";
        password = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
