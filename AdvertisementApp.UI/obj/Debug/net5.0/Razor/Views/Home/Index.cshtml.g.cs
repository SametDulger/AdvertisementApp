#pragma checksum "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07bd0918d6dd3a5cef3018d52acd8435c5b69092"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\_ViewImports.cshtml"
using AdvertisementApp.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\_ViewImports.cshtml"
using AdvertisementApp.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\_ViewImports.cshtml"
using AdvertisementApp.Common.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07bd0918d6dd3a5cef3018d52acd8435c5b69092", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4b571ca5abc8c4a5a44c48bf22479c64605a1f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProvidedServiceListDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



    <!-- Header-->
    <header class=""masthead text-center text-white"">
        <div class=""masthead-content"">
            <div class=""container px-5"">
                <h1 class=""masthead-heading mb-0"">SD Yazılım</h1>
                <h2 class=""masthead-subheading mb-0"">Masaüstü, Web ve Mobil Uygulamalar</h2>
                <a class=""btn btn-primary btn-xl rounded-pill mt-5"" href=""#scroll"">Daha fazla</a>
            </div>
        </div>
        <div class=""bg-circle-1 bg-circle""></div>
        <div class=""bg-circle-2 bg-circle""></div>
        <div class=""bg-circle-3 bg-circle""></div>
        <div class=""bg-circle-4 bg-circle""></div>
    </header>


");
#nullable restore
#line 25 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
     for (int i = 0; i < Model?.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <section id=\"scroll\">\r\n            <div class=\"container px-5\">\r\n                <div class=\"row gx-5 align-items-center\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 960, "\"", 1003, 3);
            WriteAttributeValue("", 968, "col-lg-6", 968, 8, true);
#nullable restore
#line 30 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 976, i%2==0?"order-lg-2":"", 977, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1002, "", 1003, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"p-5\"><img class=\"mb-0\"");
            BeginWriteAttribute("src", " src=\"", 1065, "\"", 1090, 1);
#nullable restore
#line 31 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1071, Model[i].ImagePath, 1071, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1154, "\"", 1196, 2);
            WriteAttributeValue("", 1162, "col-lg-6", 1162, 8, true);
#nullable restore
#line 33 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1170, i%2==0?"order-lg-1":"", 1171, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"p-5\">\r\n                            <h2 class=\"display-4\">");
#nullable restore
#line 35 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
                                             Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>");
#nullable restore
#line 36 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
                          Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 42 "C:\Users\samet\source\repos\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProvidedServiceListDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591