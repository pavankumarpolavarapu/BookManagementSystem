#pragma checksum "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3528ce3c89865eee94b3d700ee046697688866ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookManagement.Pages.Books.Pages_Books_Index), @"mvc.1.0.razor-page", @"/Pages/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Books/Index.cshtml", typeof(BookManagement.Pages.Books.Pages_Books_Index), null)]
namespace BookManagement.Pages.Books
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\_ViewImports.cshtml"
using BookManagement;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3528ce3c89865eee94b3d700ee046697688866ff", @"/Pages/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592c63409c18ea073a249343662479537112b349", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Books_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
  
    ViewData["Title"] = "Book Management Console";

#line default
#line hidden
            BeginContext(114, 38, true);
            WriteLiteral("\r\n<h2>Book Directory</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(152, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e91025a9f44e60886605a74d12e943", async() => {
                BeginContext(173, 15, true);
                WriteLiteral("Create New Book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(192, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(285, 49, false);
#line 17 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Title));

#line default
#line hidden
            EndContext();
            BeginContext(334, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(390, 49, false);
#line 20 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Genre));

#line default
#line hidden
            EndContext();
            BeginContext(439, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(495, 50, false);
#line 23 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Rating));

#line default
#line hidden
            EndContext();
            BeginContext(545, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(601, 50, false);
#line 26 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Author));

#line default
#line hidden
            EndContext();
            BeginContext(651, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(707, 51, false);
#line 29 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Edition));

#line default
#line hidden
            EndContext();
            BeginContext(758, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(814, 49, false);
#line 32 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(863, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(919, 48, false);
#line 35 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(967, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1023, 57, false);
#line 38 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].NumberOfPages));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1136, 53, false);
#line 41 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].Publisher));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1245, 57, false);
#line 44 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book[0].PublishedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 50 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
 foreach (var item in Model.Book) {

#line default
#line hidden
            BeginContext(1425, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1474, 40, false);
#line 53 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1514, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1570, 40, false);
#line 56 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1666, 41, false);
#line 59 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1763, 41, false);
#line 62 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1860, 42, false);
#line 65 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1958, 40, false);
#line 68 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1998, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2054, 39, false);
#line 71 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(2093, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2149, 48, false);
#line 74 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberOfPages));

#line default
#line hidden
            EndContext();
            BeginContext(2197, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2253, 44, false);
#line 77 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Publisher));

#line default
#line hidden
            EndContext();
            BeginContext(2297, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2353, 48, false);
#line 80 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PublishedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2401, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2456, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "656d20be0d764fcda7543b08a2d7010c", async() => {
                BeginContext(2501, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2509, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2529, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08df04deb8e64a7d962952cd18ecdfad", async() => {
                BeginContext(2577, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2588, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2608, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd5733da77ef41e7a5a92ec90c5c1644", async() => {
                BeginContext(2655, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2665, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 88 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\Books\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2704, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookManagement.Pages.Books.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookManagement.Pages.Books.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookManagement.Pages.Books.IndexModel>)PageContext?.ViewData;
        public BookManagement.Pages.Books.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
