#pragma checksum "C:\Users\laura.pennetta\source\repos\Risto.Core\Risto.MVC\Views\Shared\InfoPiatto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1a0a25a8604f1ee2350668c69c617aeded6cfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_InfoPiatto), @"mvc.1.0.view", @"/Views/Shared/InfoPiatto.cshtml")]
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
#line 1 "C:\Users\laura.pennetta\source\repos\Risto.Core\Risto.MVC\Views\_ViewImports.cshtml"
using Risto.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\laura.pennetta\source\repos\Risto.Core\Risto.MVC\Views\_ViewImports.cshtml"
using Risto.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\laura.pennetta\source\repos\Risto.Core\Risto.MVC\Views\_ViewImports.cshtml"
using Risto.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1a0a25a8604f1ee2350668c69c617aeded6cfe", @"/Views/Shared/InfoPiatto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98d74ac4e168e05ca6ea8aac043542cffadbb447", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_InfoPiatto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\n    <h3>Piatto #");
#nullable restore
#line 2 "C:\Users\laura.pennetta\source\repos\Risto.Core\Risto.MVC\Views\Shared\InfoPiatto.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <dl class=\"row\">\n        <dt class=\"col-sm-3\">\n            Nome\n        </dt>\n        <dt class=\"col-sm-3\">\n            ");
#nullable restore
#line 8 "C:\Users\laura.pennetta\source\repos\Risto.Core\Risto.MVC\Views\Shared\InfoPiatto.cshtml"
       Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dt class=\"col-sm-3\">\n            Descrizione\n        </dt>\n        <dt class=\"col-sm-3\">\n            ");
#nullable restore
#line 14 "C:\Users\laura.pennetta\source\repos\Risto.Core\Risto.MVC\Views\Shared\InfoPiatto.cshtml"
       Write(Model.Descrizione);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dt class=\"col-sm-3\">\n            Tipologia\n        </dt>\n        <dt class=\"col-sm-3\">\n            ");
#nullable restore
#line 20 "C:\Users\laura.pennetta\source\repos\Risto.Core\Risto.MVC\Views\Shared\InfoPiatto.cshtml"
       Write(Model.Tipologia);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dt class=\"col-sm-3\">\n            Prezzo\n        </dt>\n        <dt class=\"col-sm-3\">\n            ");
#nullable restore
#line 26 "C:\Users\laura.pennetta\source\repos\Risto.Core\Risto.MVC\Views\Shared\InfoPiatto.cshtml"
       Write(Model.Prezzo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n    </dl>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591