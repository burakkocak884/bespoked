#pragma checksum "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e60f1153ba676c21dd9d30d16bb5ea04939ae6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_index), @"mvc.1.0.view", @"/Views/Customer/index.cshtml")]
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
#line 1 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
using profisee_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e60f1153ba676c21dd9d30d16bb5ea04939ae6f", @"/Views/Customer/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b935d473af81893352c79cae90a290ae9ed1cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
  
    var customers = ViewBag.Customers;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div>\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e60f1153ba676c21dd9d30d16bb5ea04939ae6f5130", async() => {
                WriteLiteral("Add a New Customer");
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

<div class =""tableFixHead"">
 <table id=""customers-grid"">
                  <thead>
                    <tr>
                        <th class = ""medium-column"">Customer</th>
                        <th class = ""large-column"">Address</th>
                        <th class = ""small-column"">Phone Number</th>
                        <th class = ""medium-column"">Start Date</th>
                    </tr>
                  </thead>
");
#nullable restore
#line 21 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                     if(customers != null){
                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                       foreach(Customer customer in customers){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr >\n                              <td class = \"medium-column\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e60f1153ba676c21dd9d30d16bb5ea04939ae6f8073", async() => {
#nullable restore
#line 24 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                                                                                                                                                                           Write(customer.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 24 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                                                                                                                                                                                               Write(customer.FirstName);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-customerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                                                                                                                                             WriteLiteral(customer.customerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-customerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                              <td class = \"large-column\">");
#nullable restore
#line 25 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                                                    Write(customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                              <td class = \"small-column\">(");
#nullable restore
#line 26 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                                                     Write(customer.PhoneNumber.Substring(0,3));

#line default
#line hidden
#nullable disable
            WriteLiteral(")  ");
#nullable restore
#line 26 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                                                                                            Write(customer.PhoneNumber.Substring(3,3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                                                                                                                                 Write(customer.PhoneNumber.Substring(6,4));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                              <td class = \"medium-column\">");
#nullable restore
#line 27 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                                                     Write(customer.StartDate.ToString("MMM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n");
#nullable restore
#line 29 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/burakkocak/Development/profisee-project/Views/Customer/index.cshtml"
                       
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
    <style>
#customers-grid {
  font-family: Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#customers-grid td, #customers-grid th {
  border: 1px solid #ddd;
  padding: 8px;
}

#customers-grid tr:nth-child(even){background-color: #f2f2f2;}
#customers-grid tr:nth-child(odd){background-color: white;}


");
            WriteLiteral(@"
#customers-grid th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #f7b2a1;
  color: white;
}

.small-column{
width: 6%;
}

.medium-column{
width: 12%;
}
.large-column{
width: 20%;
}
.tableFixHead {
        overflow-y: auto; /* make the table scrollable if height is more than 200 px  */
        height: 76vh; /* gives an initial height of 200px to the table */
        width: 100%;
      }
.tableFixHead thead th {
  position: sticky; /* make the table heads sticky */
  top: 0px; /* table head will be placed from the top of the table and sticks to it */
}

</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
