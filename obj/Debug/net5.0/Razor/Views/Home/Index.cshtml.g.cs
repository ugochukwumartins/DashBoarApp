#pragma checksum "C:\Users\samson\source\repos\Dashboard\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39dc1f58fbb87fc24f4ce4db6f0db4d7db371c34"
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
#line 1 "C:\Users\samson\source\repos\Dashboard\Views\_ViewImports.cshtml"
using Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samson\source\repos\Dashboard\Views\_ViewImports.cshtml"
using Dashboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39dc1f58fbb87fc24f4ce4db6f0db4d7db371c34", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb225a8b7775b6d65d4bc41cad2c9bd60636940", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dashboard.Models.DashBoardModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\samson\source\repos\Dashboard\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            DefineSection("Stylesheets", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39dc1f58fbb87fc24f4ce4db6f0db4d7db371c345123", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"


    
        <div class=""row no-gutters"">
            <div class=""col no-gutters"">
                <div class=""Leftside"">
                    <div> <span class=""text-white"" id=""Design1"">Hello,</span><span class=""text-white"" id=""Design2"">Emerald</span></div>
                    <div>
                        <span class=""pdisign"">Welcome to your dashboard, kindly sort through the user base</span>
                    </div>
                    <div class=""input-icons"">
                        
                                <i class=""fas fa-search text-grey iconse"" aria-hidden=""true""></i>
                         <input type=""text""  placeholder=""Find a user"" class=""searcchterm""/>
                         
                    </div>
                    <div><span id=""user"">Show Users</span>/></div>
                    <div class=""btn-group icons"">
                        <div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39dc1f58fbb87fc24f4ce4db6f0db4d7db371c347326", async() => {
                WriteLiteral("<i class=\"fas fa-users fa-3x icons\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <p class=""btntext"">All Users</p>
                        </div>
                        <div>
                            <button class=""btn1""><i class=""fas fa-male fa-3x icons""></i></button>
                            <p class=""btntext"">Male Users</p>
                        </div>
                        <div>
                            <button class=""btn2""><i class=""fas fa-female fa-3x icons""></i></button>
                            <p class=""btntext"">Female Users</p>
                        </div>
                        
                        
                       

                    </div>
                </div>
              
            </div>

            <div class=""col no-gutters changedmargin"">
                <div class=""Rightside rounded-lg overflow-hidden"">
                    <div class=""flows"">

                    
                    <div class=""text1"">All User</div>
                    <div class=""text2"">Filter by</div>
     ");
            WriteLiteral("               <div class=\"btn-group\">\r\n                        <div class=\"input-icons\">\r\n                            <i class=\"fas fa-search text-grey iconses\" aria-hidden=\"true\"></i>\r\n                            <input type=\"text\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 2501, "\"", 2509, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Find in list\" id=\"Findinlist\" />\r\n                        </div>\r\n                        <div class=\"input-icons\">\r\n                            <input type=\"text\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 2699, "\"", 2707, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Country"" id=""Country"" />
                            <i class=""fa fa-caret-down dropd"" aria-hidden=""true""></i>
                        </div>

                        <div class=""container"">
                            <label class=""switch"">
                                <input type=""checkbox"">
                                <span class=""slider""></span>

                            </label>

                        </div>
                        <div class=""country"">Show </div>
                        <div>country</div>



                    </div>
                    </div>
                    <div class=""over"">

");
#nullable restore
#line 82 "C:\Users\samson\source\repos\Dashboard\Views\Home\Index.cshtml"
                         if (Model != null)
                        {
                            foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card ml-5 mt-4  cards\">\r\n                                    <div class=\"row no-gutters\">\r\n                                        <div class=\"imgholder\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=", 3777, "", 3805, 1);
#nullable restore
#line 89 "C:\Users\samson\source\repos\Dashboard\Views\Home\Index.cshtml"
WriteAttributeValue("", 3782, item.picture.thumbnail, 3782, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Alternate Text"" />
                                        </div>
                                        <div class=""detailsholde"">

                                            <div class=""nameholder"">
                                                <h6 class=""card-title"">");
#nullable restore
#line 94 "C:\Users\samson\source\repos\Dashboard\Views\Home\Index.cshtml"
                                                                  Write(item.name.fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                                            </div>\r\n                                            <div class=\"addressholder\">\r\n                                                <p class=\"card-text\">");
#nullable restore
#line 97 "C:\Users\samson\source\repos\Dashboard\Views\Home\Index.cshtml"
                                                                Write(item.location.street.fulladdress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>




                                            <div class=""contactdetails"">
                                                <div class=""iconholder"">
                                                    <i class=""fas fa-envelope-square""></i>
                                                </div>
                                                <div class=""details"">

                                                    <label id=""email"">");
#nullable restore
#line 109 "C:\Users\samson\source\repos\Dashboard\Views\Home\Index.cshtml"
                                                                 Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                </div>


                                                <div class=""iconholder"">
                                                    <i class=""fas fa-phone-volume""></i>
                                                </div>

                                                <div class=""details"">
                                                    <label id=""phonN"">");
#nullable restore
#line 118 "C:\Users\samson\source\repos\Dashboard\Views\Home\Index.cshtml"
                                                                 Write(item.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                </div>
                                                <div class=""moredetails"">
                                                    <button href=""#"" class=""moredetailsbutton""><i class=""fa fa-arrow-right reficons reficon fa-1x""></i></button>
                                                </div>

                                            </div>








                                        </div>
                                    </div>

                                </div>
");
#nullable restore
#line 137 "C:\Users\samson\source\repos\Dashboard\Views\Home\Index.cshtml"
                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dashboard.Models.DashBoardModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
