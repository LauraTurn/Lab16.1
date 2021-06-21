#pragma checksum "C:\Users\LTurner3\OneDrive - KNEX\Desktop\Lab16.1Validation\Lab16.1Validation\Views\Home\RegForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39a4b7f4ef5819a6ebc2e615566455cbb383f536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegForm), @"mvc.1.0.view", @"/Views/Home/RegForm.cshtml")]
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
#line 1 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\Lab16.1Validation\Lab16.1Validation\Views\_ViewImports.cshtml"
using Lab16._1Validation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LTurner3\OneDrive - KNEX\Desktop\Lab16.1Validation\Lab16.1Validation\Views\_ViewImports.cshtml"
using Lab16._1Validation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39a4b7f4ef5819a6ebc2e615566455cbb383f536", @"/Views/Home/RegForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d517a320720567afd2e1ef462c7286c9b3d1f4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validation()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/UserInfo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!--FIGURE OUT EMAIL VALIDATION AND DISPLAYING ERROR MESSAGE-->

<script>
    function validation() {
        //Show message next to correct box!
        let message = document.getElementById('message');

        let first = document.getElementById('first');
        let fname = /^[A-Z]{2,}$/i;
        if (first.value.match(fname) == null) {
            message.innerHTML = 'Please enter a first name that is more than 2 characters.';
            return false;
        }

        let last = document.getElementById('last');
        let lname = /^[A-Z]{2,}$/i;
        if (last.value.match(lname) == null) {
            message.innerHTML = 'Please enter a last name that is more than 2 characters.';
            return false;
        }

        let emailaddress = document.getElementById('emailaddress');
        let emailadd = /^[A-Z0-9.!#$%&'*+/=?^_`{|}~-]{2,}+*%40[A-Z0-9.!#$%&'*+/=?^_`{|}~-]{2,}+[A-Z0-9.!#$%&'*+/=?^_`{|}~-]{2,}*$/i;
        //let emailadd = /^[A-Z0-9.!#$%&'*+/=?^_`{|}~-]{2,}+&#6");
            WriteLiteral(@"4;[a-zA-Z0-9-]{2,}+(?:\.[A-Z0-9-]{2,}+)*$/i;
        if (emailaddress.value.match(emailadd) == null) {
            message.innerHTML = 'Please enter a valid email address!';
            return false;
        }

        //Do not include the pipe symbol to prevent possible leaks.
        let pass = document.getElementById('pass').value;
        let pword = /^(?=.{4,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])(?=.*?\W).*$/;
        if (pass.value.match(pword) == null) {
            message.innerHTML = 'Please enter a password that contains on uppercase letter, one lowercase letter, one number and one symbol.';
            return false;
        }

        let conpassword = document.getElementById('conpassword').value;
        if (pass != conpassword) {
            message.innerHTML = 'OOPS!  Your passwords do not match.';
            return false;
        }



        message.innerHTML = '';
        return true;

    }

</script>

<h1>Registration Form</h1>

<br />
<br />
<br />

<di");
            WriteLiteral("v id=\"message\" style=\"font-weight:bold; color:red\" align=\"center\"></div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39a4b7f4ef5819a6ebc2e615566455cbb383f5366524", async() => {
                WriteLiteral(@"
        <table border=""1"" align=""center"">

            <tr>
                <td>First Name:</td>
                <td> <input type=""text"" name=""firstname"" id=""first"" SIZE=""25""> <span id=""message"" style=""font-weight:bold; color:red"" align=""center""></span></td>
            </tr>

            <tr>
                <td> Last Name: </td>
                <td> <input type=""text"" name=""lastname"" id=""last"" SIZE=""25""> </td>
            </tr>

            <tr>
                <td> Email Address: </td>
                <td> <input type=""email"" name=""email"" id=""emailaddress"" placeholder=""eg Sparty@msu.edu"" SIZE=""25"" pattern=""/^[A-Z0-9.!#$%&'*+/=?^_`{|}~-]{2,}+*%40[A-Z0-9.!#$%&'*+/=?^_`{|}~-]{2,}+[A-Z0-9.!#$%&'*+/=?^_`{|}~-]{2,}*$/i"">
                <!--pattern=""/^[A-Z0-9.!#$%&'*+/=?^_`{|}~-]{2,}+*%40[A-Z0-9.!#$%&'*+/=?^_`{|}~-]{2,}+[A-Z0-9.!#$%&'*+/=?^_`{|}~-]{2,}*$/i""> </td>-->
            </tr>

            <tr>
                <td> Password:</td>
                <td> <input type=""password"" name=""pas");
                WriteLiteral(@"sword"" id=""pass"" SIZE=""25"" required=""required""></td>
            </tr>

            <tr>
                <td> Confirm Password:</td>
                <td> <input type=""password"" name=""confirmpassword"" id=""conpassword"" SIZE=""25"" required=""required""><span id=""message"" style=""font-weight:bold; color:red"" align=""center""></span></td>
            </tr>

            <tr>
                <td colspan=""2"" align=""right""> <input type=""Submit"" /> </td>
            </tr>

        </table>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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