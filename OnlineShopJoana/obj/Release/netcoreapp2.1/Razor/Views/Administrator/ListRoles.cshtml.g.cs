#pragma checksum "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e12d4eb1d814c11ffaa9c5f19d6681b441b2b94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_ListRoles), @"mvc.1.0.view", @"/Views/Administrator/ListRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrator/ListRoles.cshtml", typeof(AspNetCore.Views_Administrator_ListRoles))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e12d4eb1d814c11ffaa9c5f19d6681b441b2b94", @"/Views/Administrator/ListRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8786c775565a1cfbc939d5409c2686273dce8b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_ListRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
  
    ViewData["Title"] = "ListRoles";

#line default
#line hidden
            BeginContext(111, 79, true);
            WriteLiteral("\r\n<section class=\"content-header\">\r\n\r\n    <ol class=\"breadcrumb\">\r\n        <li>");
            EndContext();
            BeginContext(190, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c55accceffb4ab196c490f276c1b8fc", async() => {
                BeginContext(215, 32, true);
                WriteLiteral("<i class=\"fas fa-home\"></i> Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(251, 513, true);
            WriteLiteral(@"</li>
        <li class=""active"">Roles</li>
    </ol>
</section>


<link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css"" />
<br />

<section class=""content"">
    <div class=""row"">
        <div class=""col-md-6 center-block"">
            <div style=""text-align:center"">
                <h3 class=""card-title"">Roles</h3>
            </div>
            <div class=""box box-info"" style=""margin-top:10px"">
                <div class=""box-header with-border"">

");
            EndContext();
#line 28 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                     if (Model.Any())
                    {


#line default
#line hidden
            BeginContext(828, 706, true);
            WriteLiteral(@"                        <div class=""panel-body"">
                            <table class=""table table-hover table-responsive table-striped"" id=""MyTable"">
                                <thead>
                                    <tr>
                                        <th>
                                            Role
                                        </th>
                                        <th>
                                            Role Id
                                        </th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 45 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                                     foreach (var role in Model)
                                    {

#line default
#line hidden
            BeginContext(1639, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(1784, 39, false);
#line 49 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                                           Write(Html.DisplayFor(modelItem => role.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1823, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(1975, 37, false);
#line 52 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                                           Write(Html.DisplayFor(modelItem => role.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2012, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2163, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46a6a63b12a64be38ab24fa59fccb768", async() => {
                BeginContext(2418, 27, true);
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                                                                                                            WriteLiteral(role.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 10, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2254, "return", 2254, 6, true);
            AddHtmlAttributeValue(" ", 2260, "confirm(\'Are", 2261, 13, true);
            AddHtmlAttributeValue(" ", 2273, "you", 2274, 4, true);
            AddHtmlAttributeValue(" ", 2277, "sure", 2278, 5, true);
            AddHtmlAttributeValue(" ", 2282, "you", 2283, 4, true);
            AddHtmlAttributeValue(" ", 2286, "want", 2287, 5, true);
            AddHtmlAttributeValue(" ", 2291, "to", 2292, 3, true);
            AddHtmlAttributeValue(" ", 2294, "delete", 2295, 7, true);
#line 55 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
AddHtmlAttributeValue(" ", 2301, role.Name, 2302, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2312, "?\')", 2312, 3, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2449, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 59 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2588, 112, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            EndContext();
#line 63 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"


                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2776, 445, true);
            WriteLiteral(@"                        <div class=""card"">
                            <div class=""card-header"">
                                No roles created yet
                            </div>
                            <div class=""card-body"">
                                <h5 class=""card-title"">
                                    Use the button below to create a role
                                </h5>
                                ");
            EndContext();
            BeginContext(3221, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d12cfbafe2d4e7db1f0551119d9d516", async() => {
                BeginContext(3358, 83, true);
                WriteLiteral("\r\n                                    Create Role\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3445, 70, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 82 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                    }

#line default
#line hidden
            BeginContext(3538, 92, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3648, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 94 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(3720, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(3724, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6915273ab43d4b23bd6eb19983e1afb7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3760, 58, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
