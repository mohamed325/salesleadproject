#pragma checksum "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/Leads/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f4614418f9a496099af893742e9e1af6e233912"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leads_Index), @"mvc.1.0.view", @"/Views/Leads/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Leads/Index.cshtml", typeof(AspNetCore.Views_Leads_Index))]
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
#line 1 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/_ViewImports.cshtml"
using salesLeadNet;

#line default
#line hidden
#line 2 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/_ViewImports.cshtml"
using salesLeadNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f4614418f9a496099af893742e9e1af6e233912", @"/Views/Leads/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"379fbbdebd19428bec42cfbdd8d3b478a15f34c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Leads_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeadViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/Leads/Index.cshtml"
  
    ViewData["Title"] = "Sales Leads";

#line default
#line hidden
            BeginContext(71, 65, true);
            WriteLiteral("\r\n\r\n<div class=\"center jumbotron\">\r\n\r\n\r\n\r\n\r\n\r\n\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(136, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f4614418f9a496099af893742e9e1af6e2339123809", async() => {
                BeginContext(159, 12, true);
                WriteLiteral("Add a Player");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(175, 488, true);
            WriteLiteral(@"
    </p>


</div>

<table class=""table"">
    <thead>
        <tr>
            <th>
                firstName
            </th>

            <th>
                lastName
            </th>
            <th>
                Phone
            </th>
            <th>
                City
            </th>
            <th>
                State
            </th>
            <th>
                Zip
            </th>


        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 49 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/Leads/Index.cshtml"
         foreach (var x in Model.Leads)
        {

#line default
#line hidden
            BeginContext(715, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(776, 41, false);
#line 53 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/Leads/Index.cshtml"
               Write(Html.DisplayFor(modelItem => x.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(817, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(885, 40, false);
#line 56 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/Leads/Index.cshtml"
               Write(Html.DisplayFor(modelItem => x.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(925, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(993, 37, false);
#line 59 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/Leads/Index.cshtml"
               Write(Html.DisplayFor(modelItem => x.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1098, 36, false);
#line 62 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/Leads/Index.cshtml"
               Write(Html.DisplayFor(modelItem => x.City));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 73, true);
            WriteLiteral("\r\n\r\n\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1208, 37, false);
#line 68 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/Leads/Index.cshtml"
               Write(Html.DisplayFor(modelItem => x.State));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 71, true);
            WriteLiteral("\r\n\r\n\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1317, 35, false);
#line 73 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/Leads/Index.cshtml"
               Write(Html.DisplayFor(modelItem => x.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 52, true);
            WriteLiteral("\r\n\r\n\r\n                </td>\r\n\r\n\r\n            </tr>\r\n");
            EndContext();
#line 80 "/Users/abdikarimmohamed/MainProjects/salesLeadNet/salesLeadNet/Views/Leads/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1415, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeadViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591