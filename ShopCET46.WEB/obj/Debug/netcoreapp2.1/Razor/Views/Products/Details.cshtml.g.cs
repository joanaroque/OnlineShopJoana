#pragma checksum "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb1358aabf032a5da20d854b10da2597a985a4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
#line 1 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\_ViewImports.cshtml"
using ShopCET46.WEB;

#line default
#line hidden
#line 2 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\_ViewImports.cshtml"
using ShopCET46.WEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb1358aabf032a5da20d854b10da2597a985a4b", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dd9f678dce22c7c5954b88fc78b9e6aefa2e342", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopCET46.WEB.Data.Entities.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(211, 40, false);
#line 14 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(251, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(295, 36, false);
#line 17 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(331, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(375, 41, false);
#line 20 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(416, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(460, 37, false);
#line 23 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(497, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(541, 44, false);
#line 26 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(585, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 29 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
             if (!string.IsNullOrEmpty(Model.ImageUrl))
            {

#line default
#line hidden
            BeginContext(688, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 708, "\"", 742, 1);
#line 31 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
WriteAttributeValue("", 714, Url.Content(Model.ImageUrl), 714, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(743, 78, true);
            WriteLiteral(" alt=\"Image\" style=\"width:200px;height:300px;max-width:100%; height:auto\" />\r\n");
            EndContext();
#line 32 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(836, 41, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(878, 48, false);
#line 35 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastPurchase));

#line default
#line hidden
            EndContext();
            BeginContext(926, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(970, 44, false);
#line 38 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastPurchase));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1058, 44, false);
#line 41 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastSale));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1146, 40, false);
#line 44 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastSale));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1230, 46, false);
#line 47 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAvalible));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1320, 42, false);
#line 50 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsAvalible));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1406, 41, false);
#line 53 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1491, 37, false);
#line 56 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 54, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n   \r\n    ");
            EndContext();
            BeginContext(1582, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b53ce3386fe44c1b5f3ee2a01f926df", async() => {
                BeginContext(1652, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Projects\ShopCET46\ShopCET46.WEB\Views\Products\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1660, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1668, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c45439a542640a9a5b1299182757fc3", async() => {
                BeginContext(1714, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1730, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopCET46.WEB.Data.Entities.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
