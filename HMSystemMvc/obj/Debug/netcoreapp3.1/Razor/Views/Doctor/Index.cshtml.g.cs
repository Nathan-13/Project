#pragma checksum "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f5f71fad1d0d9364174887b542a1987eab1370"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f5f71fad1d0d9364174887b542a1987eab1370", @"/Views/Doctor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aac74cc8ccd1c6b37a71796f50f00b978be9b60", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HMSystem.Models.Doctor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Form", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<h2 style=""text-align:left"">Meet Our Practioners</h2> 
<br>
<style>
    p {
        text-align: center;
        font-size: 20px;
    }

    h4 {
        text-align: center;
    }

    a {
        text-align: center;
        font-size: 30px;
    }
</style>
<div class=""row"">
");
#nullable restore
#line 22 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
     for (int i = 0; i < Model.Count; i++) {
        if (i % 3 == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 502, "\"", 526, 1);
#nullable restore
#line 26 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 508, Model[i].ImageUrl, 508, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 527, "\"", 552, 1);
#nullable restore
#line 26 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 533, Model[i].FirstName, 533, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\" height=\"300\"/>\r\n                    <div class=\"container\">\r\n                        <h4>");
#nullable restore
#line 28 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                       Write(Model[i].FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>");
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
            WriteLiteral("</p>\r\n                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3f5f71fad1d0d9364174887b542a1987eab13707018", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-doctorId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                                                                                        WriteLiteral(Model[i].DoctorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["doctorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-doctorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["doctorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
     for (int i = 0; i < Model.Count; i++) {
        if (i % 3 != 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1237, "\"", 1261, 1);
#nullable restore
#line 42 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 1243, Model[i].ImageUrl, 1243, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1262, "\"", 1287, 1);
#nullable restore
#line 42 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 1268, Model[i].FirstName, 1268, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\" height=\"300\"/>\r\n                    <div class=\"container\">\r\n                        <h4>");
#nullable restore
#line 44 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                       Write(Model[i].FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 45 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                      Write(Model[i].Specialty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 46 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                      Write(Model[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 47 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                      Write(Model[i].PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3f5f71fad1d0d9364174887b542a1987eab137011912", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-doctorId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
                                                                                        WriteLiteral(Model[i].DoctorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["doctorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-doctorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["doctorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 52 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<br>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3f5f71fad1d0d9364174887b542a1987eab137014556", async() => {
                WriteLiteral("Add Doctor");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

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
