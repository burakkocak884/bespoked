#pragma checksum "/Users/burakkocak/Development/bespoked/Views/SalesPerson/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef9735b24f7eaaa702718e8e9174445fc43325c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesPerson_New), @"mvc.1.0.view", @"/Views/SalesPerson/New.cshtml")]
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
#line 1 "/Users/burakkocak/Development/bespoked/Views/_ViewImports.cshtml"
using profisee_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/burakkocak/Development/bespoked/Views/_ViewImports.cshtml"
using profisee_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9735b24f7eaaa702718e8e9174445fc43325c3", @"/Views/SalesPerson/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b935d473af81893352c79cae90a290ae9ed1cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SalesPerson_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 98%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SalesPerson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/New.cshtml"
  
    string msg = ViewBag.Message;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/New.cshtml"
  if(!string.IsNullOrEmpty(msg)){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"width: 80rem;\">\n         <p style = \"color: red;\">");
#nullable restore
#line 7 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/New.cshtml"
                             Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n");
#nullable restore
#line 9 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/New.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div style=\"width: 80rem;\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef9735b24f7eaaa702718e8e9174445fc43325c35048", async() => {
                WriteLiteral(@"
            <div style = ""width: 98%;display: flex;"">
                <input style = ""width: 18%;margin: 0.5%;"" type=""text"" id=""FirstName"" name=""FirstName"" placeholder = ""First Name"" required><br><br>
                <input style = ""width: 18%;margin: 0.5%;"" type=""text"" id=""LastName"" name=""LastName"" placeholder = ""Last Name"" required><br><br>
                <input style = ""width: 64%;margin: 0.5%;"" type=""text"" id=""Address"" name=""Address"" placeholder = ""Address"" required><br><br>
            </div>
            <div style = ""width: 98%;display: flex;"">
                <input style = ""width: 19%;margin: 0.5%;"" type=""text"" id=""PhoneNumber"" name=""PhoneNumber"" maxlength=""10"" minlength=""10"" placeholder = ""Phone Number"" required><br><br>
                <label class = ""date-label"" for=""StartDate"">Start Date</label>
                <input style = ""width: 24%;margin: 0.5%;"" type=""date"" id=""StartDate"" name=""StartDate"" placeholder = ""Start Date"" required><br><br>
                <label class = ""date-label"" for=""Termina");
                WriteLiteral(@"tionDate"">Termination Date</label>
                <input style = ""width: 24%;margin: 0.5%;"" type=""date"" id=""TerminationDate"" name=""TerminationDate"" placeholder = ""Termination Date"" ><br><br>

                <input  type=""hidden"" id=""managerId"" name=""managerId"" value=""1""> 
            </div>
            <div style = ""width: 99%;"">
                <input style = ""width: 98%;margin: 0.5%;"" type=""submit"" value=""Add a New Sales Person to the Team"">
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n<style>\n    .date-label{\n        font-size: 30px;\n    }\n</style>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
