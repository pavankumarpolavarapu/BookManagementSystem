#pragma checksum "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\ReservationByReturnDate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4dfae68f1a917af0ccddb8d034b357cf271fce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookManagement.Pages.Pages_ReservationByReturnDate), @"mvc.1.0.razor-page", @"/Pages/ReservationByReturnDate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ReservationByReturnDate.cshtml", typeof(BookManagement.Pages.Pages_ReservationByReturnDate), null)]
namespace BookManagement.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4dfae68f1a917af0ccddb8d034b357cf271fce0", @"/Pages/ReservationByReturnDate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592c63409c18ea073a249343662479537112b349", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ReservationByReturnDate : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 27, true);
            WriteLiteral("\r\n<h3>Reservations between ");
            EndContext();
            BeginContext(79, 11, false);
#line 6 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\ReservationByReturnDate.cshtml"
                    Write(Model.begin);

#line default
#line hidden
            EndContext();
            BeginContext(90, 279, true);
            WriteLiteral(@"</h3>
<table class=""table"">
    <thead>
        <th>
            Expected Return Date
        </th>        
        <th>
            Title
        </th>
        <th>
            Author
        </th>
        <th>
            Borrow Date
        </th>
    </thead>
");
            EndContext();
#line 22 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\ReservationByReturnDate.cshtml"
 foreach( var item in Model.Reservations)
{

#line default
#line hidden
            BeginContext(415, 24, true);
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(440, 15, false);
#line 26 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\ReservationByReturnDate.cshtml"
   Write(item.ReturnDate);

#line default
#line hidden
            EndContext();
            BeginContext(455, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(487, 15, false);
#line 29 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\ReservationByReturnDate.cshtml"
   Write(item.Book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(502, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(534, 16, false);
#line 32 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\ReservationByReturnDate.cshtml"
   Write(item.Book.Author);

#line default
#line hidden
            EndContext();
            BeginContext(550, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(582, 15, false);
#line 35 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\ReservationByReturnDate.cshtml"
   Write(item.BorrowDate);

#line default
#line hidden
            EndContext();
            BeginContext(597, 20, true);
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
            EndContext();
#line 38 "C:\Users\Pavan\Documents\GitHub\BookManagement\Pages\ReservationByReturnDate.cshtml"
}

#line default
#line hidden
            BeginContext(620, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservationByReturnDateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ReservationByReturnDateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ReservationByReturnDateModel>)PageContext?.ViewData;
        public ReservationByReturnDateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
