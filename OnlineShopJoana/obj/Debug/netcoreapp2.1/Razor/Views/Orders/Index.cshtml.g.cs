#pragma checksum "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b98323849de38151574920a8fe189553f6e41741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Index.cshtml", typeof(AspNetCore.Views_Orders_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b98323849de38151574920a8fe189553f6e41741", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8786c775565a1cfbc939d5409c2686273dce8b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineShopJoana.WEB.Data.Entities.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deliver", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnDeliver"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(104, 347, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css"" />

<div class=""top-breadcrumb-area bg-img bg-overlay d-flex align-items-center justify-content-center""
     style=""background-image: url('../template/img/bg-img/18.jpg');"">
    <h2 style=""color:#ffffff"">Orders</h2>
</div>

<br />

<p>
    ");
            EndContext();
            BeginContext(451, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f76292a02af4a74aac7627529754c06", async() => {
                BeginContext(495, 37, true);
                WriteLiteral("<i class=\"fa-plus fa\"></i> Create New");
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
            BeginContext(536, 224, true);
            WriteLiteral("\r\n</p>\r\n<br />\r\n\r\n\r\n<div class=\"col-md-12 col-md-8\" style=\"display: inline-flex; text-align: center;\">\r\n\r\n    <table class=\"table table-hover table-responsive table-striped\" id=\"MyTable\">\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
#line 27 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                 if (this.User.IsInRole("Admin"))
                {

#line default
#line hidden
            BeginContext(830, 50, true);
            WriteLiteral("                    <th>\r\n                        ");
            EndContext();
            BeginContext(881, 49, false);
#line 30 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.User.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(930, 29, true);
            WriteLiteral("\r\n                    </th>\r\n");
            EndContext();
#line 32 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(978, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(1021, 50, false);
#line 34 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderDateLocal));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1139, 48, false);
#line 37 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1255, 41, false);
#line 40 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Lines));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1364, 44, false);
#line 43 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1476, 41, false);
#line 46 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 52 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1680, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 55 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                     if (this.User.IsInRole("Admin"))
                    {

#line default
#line hidden
            BeginContext(1780, 58, true);
            WriteLiteral("                        <th>\r\n                            ");
            EndContext();
            BeginContext(1839, 48, false);
#line 58 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.User.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1887, 33, true);
            WriteLiteral("\r\n                        </th>\r\n");
            EndContext();
#line 60 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1943, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1994, 49, false);
#line 62 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderDateLocal));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2123, 47, false);
#line 65 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DeliveryDate));

#line default
#line hidden
            EndContext();
            BeginContext(2170, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2250, 40, false);
#line 68 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Lines));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2370, 43, false);
#line 71 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2413, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2493, 40, false);
#line 74 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
            EndContext();
            BeginContext(2533, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2612, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "968a704809864316b5d05a5580bdc644", async() => {
                BeginContext(2697, 27, true);
                WriteLiteral("<i class=\"fa fa-truck\"></i>");
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
#line 77 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2728, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2754, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b67ea971553d42d1b9ee0607971f9e06", async() => {
                BeginContext(2839, 27, true);
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
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
#line 78 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2870, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 81 "C:\Projects\OnlineShopJoana\OnlineShopJoana\Views\Orders\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2937, 816, true);
            WriteLiteral(@"        </tbody>
    </table>

</div>
<br />

<div id=""deleteDialog"" class=""modal fade"">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal""><i class=""fa fa-window-close""></i></button>
                <h4 class=""modal-title"">Delete</h4>
            </div>
            <div class=""modal-body"">
                <p>Do you want to delete the order?</p>
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
                BeginContext(3770, 841, true);
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#MyTable').DataTable();
        });

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
                window.location.href = '/Orders/DeleteItem/' + id;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineShopJoana.WEB.Data.Entities.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
