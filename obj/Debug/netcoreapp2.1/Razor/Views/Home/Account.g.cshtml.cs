#pragma checksum "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/Home/Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f78d9e254c6fda5b866140843d0535e43d5dcf6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Account), @"mvc.1.0.view", @"/Views/Home/Account.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Account.cshtml", typeof(AspNetCore.Views_Home_Account))]
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
#line 1 "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/_ViewImports.cshtml"
using LoginRegistration;

#line default
#line hidden
#line 2 "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/_ViewImports.cshtml"
using LoginRegistration.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78d9e254c6fda5b866140843d0535e43d5dcf6b", @"/Views/Home/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b8b69ac1923d039b18bb6580c27c9405e8eb6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserTransaction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "TransactionFormPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 429, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eff02ff4b4fd4331a3b25bc053605682", async() => {
                BeginContext(29, 416, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Account</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css""> -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(452, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(453, 1084, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5baccf89a4bb46f3afded16b172d4511", async() => {
                BeginContext(459, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(487, 49, true);
                WriteLiteral("    <div class=\"container\">\n        <h2>Welcome, ");
                EndContext();
                BeginContext(537, 16, false);
#line 14 "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/Home/Account.cshtml"
                Write(Model.User.Fname);

#line default
#line hidden
                EndContext();
                BeginContext(553, 49, true);
                WriteLiteral("</h2>\n        <h5>\n            Current balance:$ ");
                EndContext();
#line 16 "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/Home/Account.cshtml"
                                
                float counter = 0;
                foreach(var transaction in @Model.User.TransactionsMade) 
                {
                        counter = counter + @transaction.Amount;
                }
                

#line default
#line hidden
                BeginContext(832, 7, false);
#line 22 "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/Home/Account.cshtml"
           Write(counter);

#line default
#line hidden
                EndContext();
                BeginContext(854, 22, true);
                WriteLiteral("        </h5>\n        ");
                EndContext();
                BeginContext(876, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9cd0b96affda4afc95fad1d85ff4acb1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 25 "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/Home/Account.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Transaction;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(943, 145, true);
                WriteLiteral("     \n        <table>\n            <thead>\n                <th>Amount</th>\n                <th>Date</th>\n            </thead>\n            <tbody>\n");
                EndContext();
#line 32 "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/Home/Account.cshtml"
              
                foreach(var transaction in @Model.User.TransactionsMade.OrderByDescending(b => b.CreatedAt)) 
                {

#line default
#line hidden
                BeginContext(1231, 53, true);
                WriteLiteral("                    <tr>\n                        <td>");
                EndContext();
                BeginContext(1285, 18, false);
#line 36 "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/Home/Account.cshtml"
                       Write(transaction.Amount);

#line default
#line hidden
                EndContext();
                BeginContext(1303, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1338, 21, false);
#line 37 "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/Home/Account.cshtml"
                       Write(transaction.CreatedAt);

#line default
#line hidden
                EndContext();
                BeginContext(1359, 32, true);
                WriteLiteral("</td>\n                    </tr>\n");
                EndContext();
#line 39 "/Users/samguerrero/Dropbox/codo/csharp/orms/bankaccounts/LoginRegistration/Views/Home/Account.cshtml"
                }
            

#line default
#line hidden
                BeginContext(1423, 107, true);
                WriteLiteral("            </tbody>\n        </table>\n        <a style=\"float: left;\" href=\"/logout\">Logout</a>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1537, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserTransaction> Html { get; private set; }
    }
}
#pragma warning restore 1591