#pragma checksum "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5769a85c611beae80115200b57f62b80daf65de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5769a85c611beae80115200b57f62b80daf65de", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Authorization.IdentityServer.Consent.ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n    <label>\r\n        <input class=\"consent-scopecheck\"\r\n               type=\"checkbox\"\r\n               name=\"ScopesConsented\"");
            BeginWriteAttribute("id", "\r\n               id=\"", 217, "\"", 257, 2);
            WriteAttributeValue("", 238, "scopes_", 238, 7, true);
#nullable restore
#line 8 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 245, Model.Value, 245, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n               value=\"", 258, "\"", 294, 1);
#nullable restore
#line 9 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 282, Model.Value, 282, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\r\n               checked=\"", 295, "\"", 335, 1);
#nullable restore
#line 10 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 321, Model.Checked, 321, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\r\n               disabled=\"", 336, "\"", 378, 1);
#nullable restore
#line 11 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 363, Model.Required, 363, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 12 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"\r\n                   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\r\n                   value=\"", 500, "\"", 540, 1);
#nullable restore
#line 16 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 528, Model.Value, 528, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>");
#nullable restore
#line 18 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 19 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\r\n");
#nullable restore
#line 22 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </label>\r\n");
#nullable restore
#line 24 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span><em>(required)</em></span>\r\n");
#nullable restore
#line 27 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"consent-description\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 928, "\"", 953, 2);
            WriteAttributeValue("", 934, "scopes_", 934, 7, true);
#nullable restore
#line 31 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 941, Model.Value, 941, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\37544\OneDrive\Рабочий стол\Is4\Exercises\Authorization.IdentityServer\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Authorization.IdentityServer.Consent.ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591