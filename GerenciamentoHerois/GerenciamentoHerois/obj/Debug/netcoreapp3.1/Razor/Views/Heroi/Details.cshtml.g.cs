#pragma checksum "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\Heroi\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24681ef3920b186f6d86750bef06d09d38940409"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Heroi_Details), @"mvc.1.0.view", @"/Views/Heroi/Details.cshtml")]
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
#line 1 "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\_ViewImports.cshtml"
using GerenciamentoHerois;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\_ViewImports.cshtml"
using GerenciamentoHerois.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\_ViewImports.cshtml"
using GerenciamentoHerois.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24681ef3920b186f6d86750bef06d09d38940409", @"/Views/Heroi/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db24eb9f589ac6b1fcf68f0267a11a2f5d6f86bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Heroi_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Heroi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container marginTop\">\r\n    <div class=\"row\">\r\n        <div class=\"card\">\r\n            <div class=\"text-center view card-img-overlay hm-white-slight\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 199, "\"", 221, 1);
#nullable restore
#line 7 "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\Heroi\Details.cshtml"
WriteAttributeValue("", 205, Model.ImagemUrl, 205, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 240, "\"", 261, 1);
#nullable restore
#line 7 "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\Heroi\Details.cshtml"
WriteAttributeValue("", 246, Model.Codinome, 246, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <a href=\"#\">\r\n                    <div class=\"mask waves-effect waves-light\"></div>\r\n                </a>\r\n            </div>\r\n            <div class=\"card-block\">\r\n                <h2 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\Heroi\Details.cshtml"
                                  Write(Model.Codinome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\Heroi\Details.cshtml"
                                Write(Model.NomeCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\Heroi\Details.cshtml"
                                Write(Model.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\Heroi\Details.cshtml"
                                Write(Model.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\Vinicius Walsh\Documents\Dotnet\Desenvolvimento com C#\ASPNetCore-TP3-Vinicius-Walsh\GerenciamentoHerois\GerenciamentoHerois\Views\Heroi\Details.cshtml"
                                Write(Model.Poder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Heroi> Html { get; private set; }
    }
}
#pragma warning restore 1591
