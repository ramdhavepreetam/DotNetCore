#pragma checksum "D:\Preetam\Study\Core\Code\DotNetCore\OdeFoodFactory\OdeFoodFactory\Pages\Restraurants\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbae3f326f17995310716796f12653257748721e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeFoodFactory.Pages.Restraurants.Pages_Restraurants_Detail), @"mvc.1.0.razor-page", @"/Pages/Restraurants/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restraurants/Detail.cshtml", typeof(OdeFoodFactory.Pages.Restraurants.Pages_Restraurants_Detail), @"{restaurantId:int}")]
namespace OdeFoodFactory.Pages.Restraurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Preetam\Study\Core\Code\DotNetCore\OdeFoodFactory\OdeFoodFactory\Pages\_ViewImports.cshtml"
using OdeFoodFactory;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{restaurantId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbae3f326f17995310716796f12653257748721e", @"/Pages/Restraurants/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d78f1f17ab8a07040b5539695cc828a471637b49", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restraurants_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Preetam\Study\Core\Code\DotNetCore\OdeFoodFactory\OdeFoodFactory\Pages\Restraurants\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(124, 8, true);
            WriteLiteral("\r\n\r\n<h2>");
            EndContext();
            BeginContext(133, 20, false);
#line 8 "D:\Preetam\Study\Core\Code\DotNetCore\OdeFoodFactory\OdeFoodFactory\Pages\Restraurants\Detail.cshtml"
Write(Model.FoodItems.Name);

#line default
#line hidden
            EndContext();
            BeginContext(153, 22, true);
            WriteLiteral("</h2>\r\n<div>\r\n    Id: ");
            EndContext();
            BeginContext(176, 18, false);
#line 10 "D:\Preetam\Study\Core\Code\DotNetCore\OdeFoodFactory\OdeFoodFactory\Pages\Restraurants\Detail.cshtml"
   Write(Model.FoodItems.Id);

#line default
#line hidden
            EndContext();
            BeginContext(194, 31, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Location: ");
            EndContext();
            BeginContext(226, 20, false);
#line 13 "D:\Preetam\Study\Core\Code\DotNetCore\OdeFoodFactory\OdeFoodFactory\Pages\Restraurants\Detail.cshtml"
         Write(Model.FoodItems.Name);

#line default
#line hidden
            EndContext();
            BeginContext(246, 31, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Location: ");
            EndContext();
            BeginContext(278, 24, false);
#line 16 "D:\Preetam\Study\Core\Code\DotNetCore\OdeFoodFactory\OdeFoodFactory\Pages\Restraurants\Detail.cshtml"
         Write(Model.FoodItems.FoodType);

#line default
#line hidden
            EndContext();
            BeginContext(302, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(312, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6df7a00150f463f8a40d3c27ed5df3c", async() => {
                BeginContext(357, 15, true);
                WriteLiteral("All Restroaunts");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeFoodFactory.Pages.Restraurants.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeFoodFactory.Pages.Restraurants.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeFoodFactory.Pages.Restraurants.DetailModel>)PageContext?.ViewData;
        public OdeFoodFactory.Pages.Restraurants.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
