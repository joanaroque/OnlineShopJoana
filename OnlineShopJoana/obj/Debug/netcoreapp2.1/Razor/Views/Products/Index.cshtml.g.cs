#pragma checksum "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20e0e75025ff9b7a755ba39a9c570c8e0fa2284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\_ViewImports.cshtml"
using OnlineShopJoana.WEB;

#line default
#line hidden
#line 2 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\_ViewImports.cshtml"
using OnlineShopJoana.WEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20e0e75025ff9b7a755ba39a9c570c8e0fa2284", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8786c775565a1cfbc939d5409c2686273dce8b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineShopJoana.WEB.Data.Entities.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(106, 122, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css\" />\r\n\r\n<br />\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(228, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b6c8880af4747cfa438c83f7fdcad22", async() => {
                BeginContext(275, 51, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i> Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(330, 477, true);
            WriteLiteral(@"
</p>


<div class=""row"">
    <div class=""col-md-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Products</h3>
            </div>
            <div class=""panel-body"">
                <table class=""table table-hover table-responsive table-striped"" id=""MyTable"">
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(808, 40, false);
#line 27 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(848, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(952, 41, false);
#line 30 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(993, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1097, 44, false);
#line 33 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1245, 48, false);
#line 36 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.LastPurchase));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1397, 44, false);
#line 39 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.LastSale));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1545, 47, false);
#line 42 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1696, 41, false);
#line 45 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(1737, 166, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 51 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1984, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2093, 39, false);
#line 55 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2248, 40, false);
#line 58 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2288, 79, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
            EndContext();
#line 61 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                                     if (!string.IsNullOrEmpty(item.ImageUrl))
                                    {

#line default
#line hidden
            BeginContext(2486, 44, true);
            WriteLiteral("                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2530, "\"", 2563, 1);
#line 63 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
WriteAttributeValue("", 2536, Url.Content(item.ImageUrl), 2536, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2564, 77, true);
            WriteLiteral(" alt=\"Image\" style=\"width:100px;height:150px;max-width:100%;height:auto\" />\r\n");
            EndContext();
#line 64 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2680, 113, true);
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2794, 47, false);
#line 67 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.LastPurchase));

#line default
#line hidden
            EndContext();
            BeginContext(2841, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2957, 43, false);
#line 70 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.LastSale));

#line default
#line hidden
            EndContext();
            BeginContext(3000, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3116, 46, false);
#line 73 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(3162, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3278, 40, false);
#line 76 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(3318, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3433, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "846cfbb8ebf84b5bb8207affb8ce37ab", async() => {
                BeginContext(3502, 42, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-pencil\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3548, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3586, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0158010769e47e2aa64db45cf811430", async() => {
                BeginContext(3655, 40, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-list\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3699, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3737, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6999e1023cb4df6bfc5f9d2ffbb8ff9", async() => {
                BeginContext(3807, 41, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3852, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 84 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3955, 112, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4084, 236, true);
                WriteLiteral("\r\n    <script src=\"//cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js\"></script>\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\'#MyTable\').DataTable();\r\n        });\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(4323, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineShopJoana.WEB.Data.Entities.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
