#pragma checksum "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Brand\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00cf80c872772edefe31f6e5929f209f6056d9fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brand_Index), @"mvc.1.0.view", @"/Views/Brand/Index.cshtml")]
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
#line 1 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\_ViewImports.cshtml"
using P129ClassWork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00cf80c872772edefe31f6e5929f209f6056d9fd", @"/Views/Brand/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d42b188318bd114b7153f44fa2ce4d18af7b33a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Brand_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Brand>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Brand\Index.cshtml"
   
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <h1>Brands</h1>\n<ul>\n");
#nullable restore
#line 11 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Brand\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("style", "  style=\"", 124, "\"", 244, 7);
            WriteAttributeValue("", 133, "color:", 133, 6, true);
#nullable restore
#line 14 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Brand\Index.cshtml"
WriteAttributeValue("", 139, item.Id % 2 == 0 ? "red":"green", 139, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 174, ";", 174, 1, true);
            WriteAttributeValue(" ", 175, "background-color:", 176, 18, true);
#nullable restore
#line 14 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Brand\Index.cshtml"
WriteAttributeValue("", 193, item.Id % 2 == 0 ? "green":"red", 193, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 228, ";", 228, 1, true);
            WriteAttributeValue(" ", 229, "display:inline", 230, 15, true);
            EndWriteAttribute();
            WriteLiteral(">\n");
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=", 306, "", 358, 1);
#nullable restore
#line 16 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Brand\Index.cshtml"
WriteAttributeValue("", 312, "http://localhost:50628/Car/Index/"+item.Id, 312, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Brand\Index.cshtml"
                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n        </li>\n");
#nullable restore
#line 18 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Brand\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Brand>> Html { get; private set; }
    }
}
#pragma warning restore 1591
