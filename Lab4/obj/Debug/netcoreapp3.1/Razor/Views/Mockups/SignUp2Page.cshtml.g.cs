#pragma checksum "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUp2Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db7bab059f89f77c0dd1ed415882fa935e59310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_SignUp2Page), @"mvc.1.0.view", @"/Views/Mockups/SignUp2Page.cshtml")]
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
#line 1 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\_ViewImports.cshtml"
using Lab4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\_ViewImports.cshtml"
using Lab4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db7bab059f89f77c0dd1ed415882fa935e59310", @"/Views/Mockups/SignUp2Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1dc5fb44c3021da35399707c52c994f788c9f72", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_SignUp2Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUp2Page.cshtml"
  
    ViewData["Title"] = "Sign Up";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-left\">\n    <h1 class=\"display-4\">");
#nullable restore
#line 6 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUp2Page.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db7bab059f89f77c0dd1ed415882fa935e593104131", async() => {
                WriteLiteral("\n\n        <b>");
#nullable restore
#line 9 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUp2Page.cshtml"
      Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b><br>\n        ");
#nullable restore
#line 10 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUp2Page.cshtml"
   Write(Html.TextBoxFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <b>");
#nullable restore
#line 11 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUp2Page.cshtml"
      Write(ViewData["EmailConfirm"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b><br>\n\n        <b>Password</b><br>\n        <input type=\"password\" name=\"Password1Confrim\"><br>\n        <b>Confirm password</b><br>\n        <input type=\"password\" name=\"Passwor2Confrim\"> <b>");
#nullable restore
#line 16 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUp2Page.cshtml"
                                                     Write(ViewData["PasswordConfirm"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b><br>\n        ");
#nullable restore
#line 17 "C:\Users\appac\Desktop\Web4\931804.Petriva.Natalya.lab24-master\Lab4\Views\Mockups\SignUp2Page.cshtml"
   Write(Html.CheckBoxFor(model=>model.Remember));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <span>Remember?</span><br>\n        <input type=\"submit\" class=\"ButtonBlue\" name=\"submit\" value=\"Sign Up\">\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountData> Html { get; private set; }
    }
}
#pragma warning restore 1591
