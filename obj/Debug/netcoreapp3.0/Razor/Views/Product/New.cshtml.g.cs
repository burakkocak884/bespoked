#pragma checksum "/Users/burakkocak/Development/profisee-project/Views/Product/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e36a1ee77e7d5f5d05b482736bdb0257506b5a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_New), @"mvc.1.0.view", @"/Views/Product/New.cshtml")]
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
#line 1 "/Users/burakkocak/Development/profisee-project/Views/_ViewImports.cshtml"
using profisee_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/burakkocak/Development/profisee-project/Views/_ViewImports.cshtml"
using profisee_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e36a1ee77e7d5f5d05b482736bdb0257506b5a7", @"/Views/Product/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b935d473af81893352c79cae90a290ae9ed1cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 98%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
#nullable restore
#line 3 "/Users/burakkocak/Development/profisee-project/Views/Product/New.cshtml"
  
    string msg = ViewBag.Message;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "/Users/burakkocak/Development/profisee-project/Views/Product/New.cshtml"
  if(!string.IsNullOrEmpty(msg)){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"width: 80rem;\">\n            <p style = \"color: red;\">");
#nullable restore
#line 9 "/Users/burakkocak/Development/profisee-project/Views/Product/New.cshtml"
                                Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n");
#nullable restore
#line 11 "/Users/burakkocak/Development/profisee-project/Views/Product/New.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div style=\"width: 80rem;\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e36a1ee77e7d5f5d05b482736bdb0257506b5a75111", async() => {
                WriteLiteral(@"
            
        <div style = ""width: 98%;display: flex;"">
            <input style = ""width: 30%;margin: 0.5%;"" type=""text"" id=""Name"" name=""Name"" placeholder = ""Product Name""  required><br><br>
            <input style = ""width: 40%;margin: 0.5%;"" type=""text"" id=""Manufacturer"" name=""Manufacturer"" placeholder = ""Manufacturer""  required><br><br>
            <input style = ""width: 30%;margin: 0.5%;"" type=""text"" id=""Style"" name=""Style"" placeholder = ""Style""  required><br><br>
        </div>
        
        <div style = ""width: 98%;display: flex;"">
            <input style = ""width: 25%;margin: 0.5%;"" type=""number"" id=""PurchasePrice"" step=0.01 name=""PurchasePrice"" placeholder = ""Purchase Price""  required><br><br>
            <input style = ""width: 25%;margin: 0.5%;"" type=""number"" id=""SalePrice"" step=0.01 name=""SalePrice"" placeholder = ""Sale Price"" required><br><br>
            <input style = ""width: 25%;margin: 0.5%;"" type=""number"" id=""QuantityOnHand"" name=""QuantityOnHand"" placeholder = ""Quantity On Hand""  ");
                WriteLiteral(@"required><br><br>
            <input style = ""width: 25%;margin: 0.5%;"" type=""number"" id=""CommissionPercentage"" name=""CommissionPercentage"" placeholder = ""Commission Percentage""  required><br><br>
            <input  type=""hidden"" id=""productId"" name=""productId"" >
        </div>
        
        <div style = ""width: 99%;"">
            <input style = ""width: 98%;margin: 0.5%;"" type=""submit"" value=""Create a New Product"">
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
            WriteLiteral("\n</div>\n\n\n\n\n<style>\n    .date-label{\n        font-size: 30px;\n    }\n</style>");
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
