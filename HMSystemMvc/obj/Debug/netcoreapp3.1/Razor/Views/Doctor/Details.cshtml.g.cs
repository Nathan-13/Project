#pragma checksum "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f60cfb9f3117a7be92ec306180e84d527cc81ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Details), @"mvc.1.0.view", @"/Views/Doctor/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
using HMSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f60cfb9f3117a7be92ec306180e84d527cc81ca", @"/Views/Doctor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aac74cc8ccd1c6b37a71796f50f00b978be9b60", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Doctor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div>\r\n    <div>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 75, "\"", 96, 1);
#nullable restore
#line 7 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
WriteAttributeValue("", 81, Model.ImageUrl, 81, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 119, "\"", 141, 1);
#nullable restore
#line 7 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
WriteAttributeValue("", 125, Model.FirstName, 125, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"300\"/>\r\n    </div>\r\n    <br>\r\n    <br>\r\n    <div class=\"row\"> \r\n        <div class=\"col-9\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-3\">Full Name</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 15 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                                Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                <dt class=\"col-sm-3\">Doctor Identification</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 18 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                                Write(Model.DoctorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                <dt class=\"col-sm-3\">Specialty</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 21 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                                Write(Model.Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                <dt class=\"col-sm-3\">Phone number</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 24 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                                Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                <dt class=\"col-sm-3\">Email Address</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 27 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                <dt class=\"col-sm-3\">Number of Patient</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 30 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                                Write(Model.NumberOfPatient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                <dt class=\"col-sm-3\">Address</dt>\r\n                <dd class=\"col-sm-9\">");
#nullable restore
#line 33 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                                Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
            </dl>
        </div>
        <div class=""col-sm-3"">
            <table class""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Doctor treats these symptoms</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 44 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                     foreach (var sym in Model.Symptoms) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 46 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                           Write(sym.SymptomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr/>\r\n<br>\r\n <div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f60cfb9f3117a7be92ec306180e84d527cc81ca9007", async() => {
                WriteLiteral("Edit Doctor");
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
#line 57 "C:\Users\davin\dev\comit_sep20\HMSystemFull\HMSystemMvc\Views\Doctor\Details.cshtml"
                                                         WriteLiteral(Model.DoctorId);

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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f60cfb9f3117a7be92ec306180e84d527cc81ca11301", async() => {
                WriteLiteral("View Doctors");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591
