#pragma checksum "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\ImageGallery\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d6e942eb3fbfc9f3410a7710f23d44e5cfdc36426c832a76c076cc5f3dcd1617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ImageGallery_Index), @"mvc.1.0.view", @"/Views/ImageGallery/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\_ViewImports.cshtml"
using ImageGallery

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\_ViewImports.cshtml"
using ImageGallery.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d6e942eb3fbfc9f3410a7710f23d44e5cfdc36426c832a76c076cc5f3dcd1617", @"/Views/ImageGallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7553887dc212f44e71feb140ff16aa219ec4e522e2205573e152e473c793dc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ImageGallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>\r\n");
#nullable restore
#line 5 "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\ImageGallery\Index.cshtml"
     using (Html.BeginForm("Index","ImageGallery",FormMethod.Post,new{ enctype="multipart/form-data"}))
    {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"        <div class=""row"">
            <div class=""form-group col-md-6"">
                <input type=""file"" class=""form-control"" name=""file"" />
            </div>
            <div class=""form-group col-md-3"">
                <input type=""submit"" class=""btn btn-primary"" name=""submit"" value=""upload"" />
            </div>

        </div>
");
#nullable restore
#line 16 "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\ImageGallery\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n</div>\r\n<br />\r\n<div>\r\n    <div class=\"container\">\r\n        <div class=\"card border-primary\">\r\n            <div class=\"card-header font-weight-bold border-primary\">\r\n                Image Gallery\r\n            </div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 27 "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\ImageGallery\Index.cshtml"
                 if( Model!=null && Model.Any()){
                    

#line default
#line hidden
#nullable disable

#nullable restore
#line 28 "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\ImageGallery\Index.cshtml"
                     foreach(var imageFile in Model)
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <div class=\"col-md-3\" >\r\n                            <div class=\"alert alert-success\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d6e942eb3fbfc9f3410a7710f23d44e5cfdc36426c832a76c076cc5f3dcd16175835", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1028, "~/uploads/", 1028, 10, true);
            AddHtmlAttributeValue("", 1038, 
#nullable restore
#line 32 "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\ImageGallery\Index.cshtml"
                                                     imageFile

#line default
#line hidden
#nullable disable
            , 1038, 10, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            \r\n                        </div>\r\n");
#nullable restore
#line 36 "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\ImageGallery\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 36 "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\ImageGallery\Index.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <div>\r\n                        Images not available\r\n                    </div>\r\n");
#nullable restore
#line 43 "C:\Users\tusha\source\repos\ImageGallery\ImageGallery\Views\ImageGallery\Index.cshtml"
                    
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
