#pragma checksum "C:\Users\Eric\source\repos\CalculatorWithMemory\CalculatorWithMemory\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ce937abbd7ee4023d49c2f7754f028813434418"
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
#line 1 "C:\Users\Eric\source\repos\CalculatorWithMemory\CalculatorWithMemory\Views\_ViewImports.cshtml"
using CalculatorWithMemory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eric\source\repos\CalculatorWithMemory\CalculatorWithMemory\Views\_ViewImports.cshtml"
using CalculatorWithMemory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce937abbd7ee4023d49c2f7754f028813434418", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5da7675b8cb0e853f756fa8463f477b00234c52", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("calculator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Eric\source\repos\CalculatorWithMemory\CalculatorWithMemory\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\t<h1 class=\"display-4\">Calculator With Memory</h1>\r\n\t<p></p>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce937abbd7ee4023d49c2f7754f0288134344184236", async() => {
                WriteLiteral("\r\n\t\t<input type=\"text\" id=\"display\" name=\"display\"");
                BeginWriteAttribute("value", " value=\"", 223, "\"", 231, 0);
                EndWriteAttribute();
                WriteLiteral(@"/><br /><br />

		<input type=""button"" style=""height:30px; width:40px"" id=""seven"" name=""seven"" value=""7"" />
		<input type=""button"" style=""height:30px; width:40px"" id=""eight"" name=""eight"" value=""8""  />
		<input type=""button"" style=""height:30px; width:40px"" id=""nine"" name=""nine"" value=""9""  />
		<input type=""button"" style=""height:30px; width:40px"" id=""divide"" name=""divide"" value=""/"" /><br /><br />

		<input type=""button"" style=""height:30px; width:40px"" id=""four"" name=""four"" value=""4"" />
		<input type=""button"" style=""height:30px; width:40px"" id=""five"" name=""five"" value=""5"" />
		<input type=""button"" style=""height:30px; width:40px"" id=""six"" name=""six"" value=""6"" />
		<input type=""button"" style=""height:30px; width:40px"" id=""mulitiply"" name=""mulitiply"" value=""*"" /><br /><br />

		<input type=""button"" style=""height:30px; width:40px"" id=""one"" name=""one"" value=""1"" />
		<input type=""button"" style=""height:30px; width:40px"" id=""two"" name=""two"" value=""2"" />
		<input type=""button"" style=""height:30px; width:40px""");
                WriteLiteral(@" id=""three"" name=""three"" value=""3"" />
		<input type=""button"" style=""height:30px; width:40px"" id=""minus"" name=""minus"" value=""-"" /><br /><br />

		<input type=""button"" style=""height:30px; width:40px"" id=""zero"" name=""zero"" value=""0""  />
		<input type=""button"" style=""height:30px; width:40px"" id=""dot"" name=""dot"" value="".""  />
		<input type=""button"" style=""height:30px; width:40px"" id=""plus"" name=""plus"" value=""+"" /><br /><br />

		<input type=""button"" style=""height:30px; width:85px"" id=""clear"" name=""clear"" value=""Clear"" />
		<input type=""submit"" style=""height:30px; width:85px"" id=""submit"" name=""submit"" value=""Enter""/>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<hr />\r\n<div class=\"text-center\">\r\n\t<ul id=\"messagesList\" class=\"nobullets\"></ul>\r\n</div>\r\n");
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
