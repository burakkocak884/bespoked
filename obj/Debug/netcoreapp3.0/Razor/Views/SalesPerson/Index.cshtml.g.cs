#pragma checksum "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e581dcc17160ebf12ac8738f4335cc08282edd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesPerson_Index), @"mvc.1.0.view", @"/Views/SalesPerson/Index.cshtml")]
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
#line 1 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
using profisee_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e581dcc17160ebf12ac8738f4335cc08282edd2", @"/Views/SalesPerson/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b935d473af81893352c79cae90a290ae9ed1cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SalesPerson_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SalesPerson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
  
    var salesPeople = ViewBag.SalesPeople;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e581dcc17160ebf12ac8738f4335cc08282edd25166", async() => {
                WriteLiteral("Add a New Sales Person to the Team");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
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
 <table id=""salespeople-grid"">
                    <tr>
                        <th class = ""medium-column"">Name</th>
                        <th class = ""large-column"">Address</th>
                        <th class = ""small-column"">Phone Number</th>
                        <th class = ""medium-column"">Start Date</th>
                        <th class = ""medium-column"">Termination Date</th>
                    </tr>
");
#nullable restore
#line 16 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                     if(salesPeople != null){
                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                       foreach(SalesPerson person in salesPeople){
                        string termDate = @person.TerminationDate.ToString() == "1/1/0001 12:00:00 AM"? "Current Employee": @person.TerminationDate.ToString("MMM dd yyyy");
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr >\n                              <td class = \"medium-column\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e581dcc17160ebf12ac8738f4335cc08282edd28284", async() => {
#nullable restore
#line 20 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                                                                                                                                                                                  Write(person.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 20 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                                                                                                                                                                                                    Write(person.FirstName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-salesPersonId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                                                                                                                                                   WriteLiteral(person.salesPersonId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["salesPersonId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-salesPersonId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["salesPersonId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                              <td class = \"large-column\">");
#nullable restore
#line 21 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                                                    Write(person.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                              <td class = \"small-column\">(");
#nullable restore
#line 22 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                                                     Write(person.PhoneNumber.Substring(0,3));

#line default
#line hidden
#nullable disable
            WriteLiteral(")  ");
#nullable restore
#line 22 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                                                                                          Write(person.PhoneNumber.Substring(3,3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                                                                                                                             Write(person.PhoneNumber.Substring(6,4));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                              <td class = \"medium-column\">");
#nullable restore
#line 23 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                                                     Write(person.StartDate.ToString("MMM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                              <td class = \"medium-column\">");
#nullable restore
#line 24 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                                                     Write(termDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n");
#nullable restore
#line 26 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/burakkocak/Development/bespoked/Views/SalesPerson/Index.cshtml"
                       
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>



    <style>
#salespeople-grid {
  font-family: Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#salespeople-grid td, #salespeople-grid th {
  border: 1px solid #ddd;
  padding: 8px;
}

#salespeople-grid tr:nth-child(even){background-color: #f2f2f2;}
#salespeople-grid tr:nth-child(odd){background-color: white;}


");
            WriteLiteral("\n#salespeople-grid th {\n  padding-top: 12px;\n  padding-bottom: 12px;\n  text-align: left;\n  background-color: #f7b2a1;\n  color: white;\n}\n\n.small-column{\nwidth: 6%;\n}\n\n.medium-column{\nwidth: 10%;\n}\n.large-column{\nwidth: 20%;\n}\n\n\n</style>");
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
