#pragma checksum "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdb8b2ecb35d593fad72ebbf1e964c36478db97c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdb8b2ecb35d593fad72ebbf1e964c36478db97c", @"/Views/Administrator/ListRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8786c775565a1cfbc939d5409c2686273dce8b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_ListRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
  
    ViewData["Title"] = "ListRoles";

#line default
#line hidden
            BeginContext(111, 310, true);
            WriteLiteral(@"



<div class=""top-breadcrumb-area bg-img bg-overlay d-flex align-items-center justify-content-center""
     style=""background-image: url('../template/img/bg-img/18.jpg');"">
    <h2 style=""color:#ffffff"">Roles</h2>
</div>

<br />

<div class=""col-md-12 col-md-8"" style=""display: inline-flex;"">


");
            EndContext();
#line 20 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
     if (Model.Any())
    {


#line default
#line hidden
            BeginContext(453, 340, true);
            WriteLiteral(@"        <table class=""table"">
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
#line 36 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                 foreach (var role in Model)
                {

#line default
#line hidden
            BeginContext(858, 126, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <strong>\r\n                                ");
            EndContext();
            BeginContext(985, 39, false);
#line 41 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                           Write(Html.DisplayFor(modelItem => role.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 130, true);
            WriteLiteral("\r\n                            </strong>\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1155, 37, false);
#line 45 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                       Write(Html.DisplayFor(modelItem => role.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1252, "\"", 1265, 1);
#line 47 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
WriteAttributeValue("", 1257, role.Id, 1257, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1266, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(1297, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287b075331704d4d9ec2dba8c1fc7410", async() => {
                BeginContext(1460, 27, true);
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                                                                                        WriteLiteral(role.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1491, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 52 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
                }

#line default
#line hidden
            BeginContext(1570, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 55 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1634, 301, true);
            WriteLiteral(@"        <div class=""card"">
            <div class=""card-header"">
                No roles created yet
            </div>
            <div class=""card-body"">
                <h5 class=""card-title"">
                    Use the button below to create a role
                </h5>
                ");
            EndContext();
            BeginContext(1935, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae80bc2e3d3b4090802716344ce9da6c", async() => {
                BeginContext(2056, 51, true);
                WriteLiteral("\r\n                    Create Role\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2111, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 72 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
    }

#line default
#line hidden
            BeginContext(2156, 778, true);
            WriteLiteral(@"
</div>
<div id=""deleteDialog"" class=""modal fade"">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""><i class=""fa fa-window-close""></i></button>
                <h4 class=""modal-title"">Delete</h4>
            </div>
            <div class=""modal-body"">
                <p>Do you want to delete this role?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""btnYesDelete"">Delete</button>
                <button type=""button"" class=""btn btn-success"" id=""btnNoDelete"">No</button>
            </div>
        </div>
    </div>
</div>

<br />



");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2952, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 98 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Administrator\ListRoles.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(3022, 676, true);
                WriteLiteral(@"    <script type=""text/javascript"">
      
        $(document).ready(function () {

            let id = 0;

            $('a[id*=btnDelete]').click(function () {
                debugger;
                id = $(this).parent()[0].id;
                $(""#deleteDialog"").modal('show');
                return false;
            });

            $(""#btnNoDelete"").click(function () {
                $(""#deleteDialog"").modal('hide');
                return false;
            });

            $(""#btnYesDelete"").click(function () {
                window.location.href = '/Administrator/DeleteRole/' + id;
            });

        });


    </script>

");
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
