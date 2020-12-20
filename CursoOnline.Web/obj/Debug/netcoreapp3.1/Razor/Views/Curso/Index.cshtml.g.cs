#pragma checksum "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64ef3e0e6086f0f8b418406d7841f7054a8e1057"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Index), @"mvc.1.0.view", @"/Views/Curso/Index.cshtml")]
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
#line 1 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\_ViewImports.cshtml"
using CursoOnline.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\_ViewImports.cshtml"
using CursoOnline.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
using CursoOnline.Dominio.Cursos.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
using CursoOnline.Web.Util;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64ef3e0e6086f0f8b418406d7841f7054a8e1057", @"/Views/Curso/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0d8200179469d3ff6fec63422201671018f588", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CursoOnline.Web.Util.PaginatedList<CursoDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
  
    ViewData["Title"] = "Cursos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""pad-wrapper"">
    <div class=""row"">
        <div class=""col-md-12"">
            <a href=""/Cursos"" class=""btn"">Voltar</a>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <a href=""/Curso/Novo"" class=""btn btn-primary"">Novo</a>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>Carga Horária</th>
                        <th>Público Alvo</th>
                        <th>Valor</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 33 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 37 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
                           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 40 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
                           Write(item.CargaHoraria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 43 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
                           Write(item.PublicoAlvo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 46 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
                           Write(item.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1528, "\"", 1557, 2);
            WriteAttributeValue("", 1535, "/Curso/Editar/", 1535, 14, true);
#nullable restore
#line 49 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
WriteAttributeValue("", 1549, item.Id, 1549, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\">Editar</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 52 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n");
#nullable restore
#line 56 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
              
                var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
                var nextDisabled = !Model.HasNextPage ? "disabled" : "";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ef3e0e6086f0f8b418406d7841f7054a8e10578081", async() => {
                WriteLiteral("Anterior");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
                                       WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1988, "btn", 1988, 3, true);
            AddHtmlAttributeValue(" ", 1991, "btn-default", 1992, 12, true);
#nullable restore
#line 61 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
AddHtmlAttributeValue(" ", 2003, prevDisabled, 2004, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ef3e0e6086f0f8b418406d7841f7054a8e105710925", async() => {
                WriteLiteral("Próximo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
                                       WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2114, "btn", 2114, 3, true);
            AddHtmlAttributeValue(" ", 2117, "btn-default", 2118, 12, true);
#nullable restore
#line 62 "c:\Users\jocm\My Private Documents\codes\Estudo TDD\Curso Online\CursoOnline.Web\Views\Curso\Index.cshtml"
AddHtmlAttributeValue(" ", 2129, nextDisabled, 2130, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CursoOnline.Web.Util.PaginatedList<CursoDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
