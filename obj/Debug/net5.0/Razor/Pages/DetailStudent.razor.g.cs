#pragma checksum "D:\Codes\frontend_blazor\UASBlazor\Pages\DetailStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e90e57bf8d065306fa1fbf75210a7adc836ba66b"
// <auto-generated/>
#pragma warning disable 1591
namespace UASBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Codes\frontend_blazor\UASBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Codes\frontend_blazor\UASBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Codes\frontend_blazor\UASBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Codes\frontend_blazor\UASBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Codes\frontend_blazor\UASBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Codes\frontend_blazor\UASBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Codes\frontend_blazor\UASBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Codes\frontend_blazor\UASBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Codes\frontend_blazor\UASBlazor\_Imports.razor"
using UASBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Codes\frontend_blazor\UASBlazor\_Imports.razor"
using UASBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detail/{id}")]
    public partial class DetailStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\Codes\frontend_blazor\UASBlazor\Pages\DetailStudent.razor"
 if(Student ==  null ){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 6 "D:\Codes\frontend_blazor\UASBlazor\Pages\DetailStudent.razor"
}
else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-sm-8");
            __builder.AddMarkupContent(3, "<h2> Details</h2>\r\n            ");
            __builder.AddMarkupContent(4, "<h3> Students</h3>\r\n            <hr>\r\n            ");
            __builder.OpenElement(5, "h4");
            __builder.AddContent(6, " NIM            : ");
            __builder.AddContent(7, 
#nullable restore
#line 12 "D:\Codes\frontend_blazor\UASBlazor\Pages\DetailStudent.razor"
                                   Student.studentID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "h4");
            __builder.AddContent(10, " Nama Belakang  : ");
            __builder.AddContent(11, 
#nullable restore
#line 13 "D:\Codes\frontend_blazor\UASBlazor\Pages\DetailStudent.razor"
                                   Student.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "h4");
            __builder.AddContent(14, " Nama Depan     : ");
            __builder.AddContent(15, 
#nullable restore
#line 14 "D:\Codes\frontend_blazor\UASBlazor\Pages\DetailStudent.razor"
                                   Student.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "h4");
            __builder.AddContent(18, " Tanggal Masuk  : ");
            __builder.AddContent(19, 
#nullable restore
#line 15 "D:\Codes\frontend_blazor\UASBlazor\Pages\DetailStudent.razor"
                                   Student.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        <br>\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-sm-8");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", 
#nullable restore
#line 19 "D:\Codes\frontend_blazor\UASBlazor\Pages\DetailStudent.razor"
                       $"edit/{Student.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, "<a href=\"studentspage\"> Back to List</a>");
            __builder.CloseElement();
#nullable restore
#line 22 "D:\Codes\frontend_blazor\UASBlazor\Pages\DetailStudent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
