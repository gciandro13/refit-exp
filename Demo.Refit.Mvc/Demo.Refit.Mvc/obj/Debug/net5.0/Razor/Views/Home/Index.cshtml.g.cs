#pragma checksum "C:\projects\BE\Demo\Refit\Demo.Refit.Mvc\Demo.Refit.Mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b850996c58949ecd81077951a569222b549014fb"
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
#line 1 "C:\projects\BE\Demo\Refit\Demo.Refit.Mvc\Demo.Refit.Mvc\Views\_ViewImports.cshtml"
using Demo.Refit.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\BE\Demo\Refit\Demo.Refit.Mvc\Demo.Refit.Mvc\Views\_ViewImports.cshtml"
using Demo.Refit.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b850996c58949ecd81077951a569222b549014fb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ffb67bde53f3b03910253b0606486b33a242e22", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\projects\BE\Demo\Refit\Demo.Refit.Mvc\Demo.Refit.Mvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <input type=\"text\" id=\"inputmsg\" name=\"inputmsg\"");
            BeginWriteAttribute("value", " value=\"", 280, "\"", 288, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    <input type=""button"" name=""submit"" id=""submit"" value=""Markdown_Github"" onclick=""useRefit()"" />
</div>
<div class=""text-center mt-3"">
    <textarea id=""res""></textarea>
</div>

<div class=""text-center mt-5"">
    <input type=""text"" id=""inputmsg1"" name=""inputmsg1""");
            BeginWriteAttribute("value", " value=\"", 566, "\"", 574, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    <input type=""button"" name=""submitSpot"" id=""submitSpot"" value=""Get_NameAge"" onclick=""useRefitNameAge()"" />
</div>
<div class=""text-center mt-3"">
    <textarea id=""res2""></textarea>
</div>

<script>
    function useRefit() {
        debugger;
        var inputmsg = $(""#inputmsg"").val();
        debugger;
        $.post(""/Home/Refit"", { msg: inputmsg }, function (data) {
            $(""#res"").html(data);
        });
    }

    function useRefitNameAge() {
        debugger;
        var inputmsg1 = $(""#inputmsg1"").val();
        debugger;
        $.get(""/Home/RefitNameAge"", { name: inputmsg1 }, function (data) {
            $(""#res2"").html(data);
        });
    }
</script>
");
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
