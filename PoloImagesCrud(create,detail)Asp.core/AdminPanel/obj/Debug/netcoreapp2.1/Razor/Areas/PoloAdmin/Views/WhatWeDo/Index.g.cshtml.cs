#pragma checksum "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef275ad8285b29e4eb274da886b89a20e08561ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PoloAdmin_Views_WhatWeDo_Index), @"mvc.1.0.view", @"/Areas/PoloAdmin/Views/WhatWeDo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PoloAdmin/Views/WhatWeDo/Index.cshtml", typeof(AspNetCore.Areas_PoloAdmin_Views_WhatWeDo_Index))]
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
#line 1 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\_ViewImports.cshtml"
using AdminPanel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef275ad8285b29e4eb274da886b89a20e08561ff", @"/Areas/PoloAdmin/Views/WhatWeDo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8998aa867823415ee49a61948628119d2f2f7600", @"/Areas/PoloAdmin/Views/_ViewImports.cshtml")]
    public class Areas_PoloAdmin_Views_WhatWeDo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WhatWeDo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
  
    ViewData["Title"] = "What We Do";

#line default
#line hidden
            BeginContext(76, 134, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"card\">\r\n                ");
            EndContext();
            BeginContext(210, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1728a09ce3441cf9cc6d5e320041067", async() => {
                BeginContext(257, 7, true);
                WriteLiteral(" Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(268, 570, true);
            WriteLiteral(@"
                <div class=""card-body"">
                    <h5 class=""card-title m-b-0"">What We Do</h5>
                </div>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Title</th>
                            <th scope=""col"">Description</th>
                            <th scope=""col""></th>
                        </tr>
                        
                    </thead>
                    <tbody>

");
            EndContext();
#line 26 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                           
                           
                            int count = 1;
                        

#line default
#line hidden
            BeginContext(967, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 30 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                         foreach (var skill in Model)
                        {

#line default
#line hidden
            BeginContext(1049, 82, true);
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
            EndContext();
            BeginContext(1132, 5, false);
#line 33 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                                           Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1137, 43, true);
            WriteLiteral("</th>\r\n                                <td>");
            EndContext();
            BeginContext(1181, 11, false);
#line 34 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                               Write(skill.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1192, 45, true);
            WriteLiteral("</td>\r\n                                <td>\r\n");
            EndContext();
#line 36 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                                     if (skill.Description.Length > 30)
                                    {
                                        

#line default
#line hidden
            BeginContext(1391, 42, false);
#line 38 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                                    Write(skill.Description.Substring(0, 30) + "...");

#line default
#line hidden
            EndContext();
#line 38 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                                                                                     
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
            BeginContext(1597, 17, false);
#line 42 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                                   Write(skill.Description);

#line default
#line hidden
            EndContext();
#line 42 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                                                          
                                    }

#line default
#line hidden
            BeginContext(1655, 113, true);
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1768, 182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "349bcfe9086649d6be0d9e4f137f106e", async() => {
                BeginContext(1840, 106, true);
                WriteLiteral("\r\n                                        <i class=\"fas fa-eye\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                                                             WriteLiteral(skill.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1950, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1988, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be1d8268e3de414fb3f5dbd969dce117", async() => {
                BeginContext(2060, 107, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-edit\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                                                             WriteLiteral(skill.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2171, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2209, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b63ccab5c1b64cebb5e788fae25ac870", async() => {
                BeginContext(2280, 112, true);
                WriteLiteral("\r\n                                        <i class=\"fas fa-trash-alt\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                                                             WriteLiteral(skill.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2396, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Cavid\source\repos\Asp.net\AdminPanelFirstPart\AdminPanel\AdminPanel\Areas\PoloAdmin\Views\WhatWeDo\Index.cshtml"
                            count++;
                        }

#line default
#line hidden
            BeginContext(2537, 114, true);
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WhatWeDo>> Html { get; private set; }
    }
}
#pragma warning restore 1591