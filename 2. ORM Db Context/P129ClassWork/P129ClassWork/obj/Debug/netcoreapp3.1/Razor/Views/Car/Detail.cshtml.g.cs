#pragma checksum "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Car\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60fe5224a63e1de99025980b5df36ec6bb0f8b59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Detail), @"mvc.1.0.view", @"/Views/Car/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fe5224a63e1de99025980b5df36ec6bb0f8b59", @"/Views/Car/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d42b188318bd114b7153f44fa2ce4d18af7b33a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Car Detail</h1>\r\n<ul>\r\n    <li>");
#nullable restore
#line 4 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Car\Detail.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 5 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Car\Detail.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 6 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Car\Detail.cshtml"
   Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 7 "C:\Users\hamid.mammadov\Documents\P129\2. ORM Db Context\P129ClassWork\P129ClassWork\Views\Car\Detail.cshtml"
   Write(Model.EngineType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591