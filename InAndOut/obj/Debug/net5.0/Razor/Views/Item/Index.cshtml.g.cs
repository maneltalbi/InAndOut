#pragma checksum "C:\Users\DELL\source\repos\InAndOut\InAndOut\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "427b802dc38849157562bee2cea39dda71cfbbe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\InAndOut\InAndOut\Views\_ViewImports.cshtml"
using InAndOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\InAndOut\InAndOut\Views\_ViewImports.cshtml"
using InAndOut.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"427b802dc38849157562bee2cea39dda71cfbbe8", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68bf42a2f6da1b0bba0ff4b16a23c8e4ecef32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InAndOut.Models.Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container p-3"">
    <div class=""row pt-4"">
        <div class=""col-6"">
        <h2 class=""text-primary"">Borrowed Items List</h2>
        </div>
        <div class=""col-6"">
            Create new Item
        </div>
    </div>
    <br/>
");
#nullable restore
#line 14 "C:\Users\DELL\source\repos\InAndOut\InAndOut\Views\Item\Index.cshtml"
    if(Model.Count()>0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-bordered table-striped"" style=""width:100%"">
                    <thead>
                        <tr>
                            <th>
                                Item Name
                            </th>
                            <th>
                                Borrower
                            </th>
                            <th>
                                Lender
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 31 "C:\Users\DELL\source\repos\InAndOut\InAndOut\Views\Item\Index.cshtml"
                         foreach(var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td width=\"30%\"></td>\r\n                            <td width=\"30%\"> ");
#nullable restore
#line 35 "C:\Users\DELL\source\repos\InAndOut\InAndOut\Views\Item\Index.cshtml"
                                        Write(item.Borrower);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"30%\">");
#nullable restore
#line 36 "C:\Users\DELL\source\repos\InAndOut\InAndOut\Views\Item\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\DELL\source\repos\InAndOut\InAndOut\Views\Item\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n\r\n                </table> \r\n");
#nullable restore
#line 43 "C:\Users\DELL\source\repos\InAndOut\InAndOut\Views\Item\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>No Items created yet</p>\r\n");
#nullable restore
#line 47 "C:\Users\DELL\source\repos\InAndOut\InAndOut\Views\Item\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InAndOut.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
