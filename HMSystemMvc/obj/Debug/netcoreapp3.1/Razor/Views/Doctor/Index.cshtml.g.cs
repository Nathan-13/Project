#pragma checksum "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "991c3fcbfd372d4cea8094832cf7d7f7bd394645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Index), @"mvc.1.0.view", @"/Views/Doctor/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\_ViewImports.cshtml"
using HMSystemMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\_ViewImports.cshtml"
using HMSystemMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"991c3fcbfd372d4cea8094832cf7d7f7bd394645", @"/Views/Doctor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aac74cc8ccd1c6b37a71796f50f00b978be9b60", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HMSystem.Models.Doctor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2 style=\"text-align:center\">Our Doctors</h2> \r\n<br>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
     for (int i = 0; i < Model.Count; i++) {
        if (i % 2 == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 282, "\"", 306, 1);
#nullable restore
#line 10 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 288, Model[i].ImageUrl, 288, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 307, "\"", 332, 1);
#nullable restore
#line 10 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 313, Model[i].FirstName, 313, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\"/>\r\n                    <div class=\"container\">\r\n                        <h3>");
#nullable restore
#line 12 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                       Write(Model[i].FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"specialty\">");
#nullable restore
#line 13 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                                        Write(Model[i].Specialty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 14 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                      Write(Model[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 15 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                      Write(Model[i].PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><button class=\"button\">Contact</button></p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
     for (int i = 0; i < Model.Count; i++) {
        if (i % 2 != 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 957, "\"", 981, 1);
#nullable restore
#line 26 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 963, Model[i].ImageUrl, 963, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 982, "\"", 1007, 1);
#nullable restore
#line 26 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 988, Model[i].FirstName, 988, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\"/>\r\n                    <div class=\"container\">\r\n                        <h3>");
#nullable restore
#line 28 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                       Write(Model[i].FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"specialty\">");
#nullable restore
#line 29 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                                        Write(Model[i].Specialty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 30 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                      Write(Model[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 31 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                      Write(Model[i].PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><button class=\"button\">Contact</button></p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<!--
    <div class=""column"">
        <div class=""card"">
            <img src=""binder.jpg"" alt=""Binder"" style=""width:100%"">
            <div class=""container"">
                <h2>Mike Ross</h2>
                <p class=""title"">Art Director</p>
                <p>Some text that describes me lorem ipsum ipsum lorem.</p>
                <p>mike@example.com</p>
                <p><button class=""button"">Contact</button></p>
            </div>
        </div>
    </div>

    <div class=""column"">
        <div class=""card"">
            <img src=""painter.jpg"" alt=""Painter"" style=""width:100%"">
            <div class=""container"">
                <h2>John Doe</h2>
                <p class=""title"">Designer</p>
                <p>Some text that describes me lorem ipsum ipsum lorem.</p>
                <p>john@example.com</p>
                <p><button class=""button"">Contact</button></p>
            </div>
        </div>
    </div>
-->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HMSystem.Models.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
