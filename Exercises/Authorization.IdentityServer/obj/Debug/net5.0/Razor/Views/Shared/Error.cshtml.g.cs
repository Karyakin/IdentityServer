#pragma checksum "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14c518112130f7c39cca7e78632774f4193fa530"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14c518112130f7c39cca7e78632774f4193fa530", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Authorization.IdentityServer.Home.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\Error.cshtml"
  
    var error = Model?.Error?.Error;
    var errorDescription = Model?.Error?.ErrorDescription;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"error-page\">\r\n    <div class=\"lead\">\r\n        <h1>Error</h1>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <div class=\"alert alert-danger\">\r\n                Sorry, there was an error\r\n\r\n");
#nullable restore
#line 19 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <strong>\r\n                        <em>\r\n                            : ");
#nullable restore
#line 23 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\Error.cshtml"
                         Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </em>\r\n                    </strong>\r\n");
#nullable restore
#line 26 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\Error.cshtml"

                    if (errorDescription != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>");
#nullable restore
#line 29 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\Error.cshtml"
                        Write(errorDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 30 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\Error.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
#nullable restore
#line 36 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 37 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Authorization.IdentityServer.Home.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
