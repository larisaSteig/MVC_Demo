#pragma checksum "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9bc3b06b8946856e2348d2f92d06d090d257b59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bc3b06b8946856e2348d2f92d06d090d257b59", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e4996073d576984abf173902213fa20e43f99f", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCDemo.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Students";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>\r\n    ");
#nullable restore
#line 7 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
Write(TempData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h3>\r\n\r\n<table id=\"uxTable\" class=\"table\">\r\n    <thead class=\"bg-dark text-white\">\r\n        <tr>\r\n            <th>");
#nullable restore
#line 13 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 14 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th>");
#nullable restore
#line 15 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
         foreach (var s in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(m => s.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(m => s.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(m => s.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 29 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
 if (User.IsInRole("Developer"))
{
    Html.ActionLink("Add New Student", "Add");
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 36 "C:\Users\Manpower\Desktop\ASP_NET class\DAY 6_MVC\MVCDemo\MVCDemo\Views\Student\Index.cshtml"
Write(Html.ActionLink("Student Details", "Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<p>
    <button id=""usAddClass"" class=""btn btn-primary"">Add table class</button>
</p>

<script>
    $(document).ready(function () {
        $(""#usAddClass"").click(function () {
            $(""#uxTable"").addClass(""table-bordered"");
        })
    });

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCDemo.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
