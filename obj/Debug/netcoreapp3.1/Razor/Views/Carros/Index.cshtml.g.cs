#pragma checksum "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13d6aaed5a63153c15f6375d56761c0f12fbb356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carros_Index), @"mvc.1.0.view", @"/Views/Carros/Index.cshtml")]
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
#line 1 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\_ViewImports.cshtml"
using CarWebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\_ViewImports.cshtml"
using CarWebMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d6aaed5a63153c15f6375d56761c0f12fbb356", @"/Views/Carros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6a543b1b54c86a2fdd477ae58c1fc4fb471293", @"/Views/_ViewImports.cshtml")]
    public class Views_Carros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarWebMVC.Models.Carro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13d6aaed5a63153c15f6375d56761c0f12fbb3564827", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13d6aaed5a63153c15f6375d56761c0f12fbb3565870", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13d6aaed5a63153c15f6375d56761c0f12fbb3566913", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 10 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function() {
                $('#welcome').modal('show');
        })
</script>
<div class=""modal fade"" id=""welcome"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Olá, Clécio&nbsp;&nbsp;</h4>
                <img [src]=""img"" title=""Clécio Stark"" src=""https://i.pinimg.com/236x/52/b2/8b/52b28bc2cf4cbc5dcb8dfa1ce1b2c9ef.jpg"" style=""width:5%; height:5%"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar""><span aria-hidden=""true"">&times;</span></button>
            </div>
            <div class=""modal-body"">
                <h2 class=""display-4"">Seja muito Bem-Vindo Stark</h2>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-dark"" data");
            WriteLiteral("-dismiss=\"modal\"><strong>Fechar</strong></button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<a class=\"btn btn-success btn-xs\" href=\"/Carros/CadastrarCarro\" style=\"padding: 6px; font-size: medium; float: right\">Cadastrar novo Carro</a>\r\n");
#nullable restore
#line 35 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
Write(Html.ActionLink("Popular Carros","PopularCarro","Carros",null,new { @class = "btn btn-dark btn-xs", style="padding: 6px; font-size: medium; float: right; margin: 0 10px;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 class=""display-4"">Lista de Carros</h3>

<div id=""list"" class=""row"" style=""margin:0;"">
    <div class=""table-responsive col-md-12"">
        <table class=""table table-striped table-dark table-bordered table-hover"" style=""margin: 0"">
            <thead>
                <tr>
                    <th>Placa</th>
                    <th>Marca</th>
                    <th>Modelo</th>
                    <th>Cor</th>
                    <th>Preço</th>
                    <th class=""actions"">Opções</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 52 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                 foreach (var carros in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                       Write(carros.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                       Write(carros.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                       Write(carros.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 58 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                       Write(carros.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>R$ ");
#nullable restore
#line 59 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                          Write(carros.Preco.ToString("F2", CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td class=""actions"">
                            <a class=""btn btn-primary btn-xs"" style=""padding: 4px"" href=""#"" data-toggle=""modal"" data-target=""#myModal"">Visualizar</a>
                            <a class=""btn btn-warning btn-xs"" style=""padding: 4px""");
            BeginWriteAttribute("href", " href=\"", 3012, "\"", 3049, 2);
            WriteAttributeValue("", 3019, "/Carros/EditarCarro/", 3019, 20, true);
#nullable restore
#line 62 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
WriteAttributeValue("", 3039, carros.Id, 3039, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                            <a class=\"btn btn-danger btn-xs\" style=\"padding: 4px\"");
            BeginWriteAttribute("href", " href=\"", 3144, "\"", 3187, 2);
            WriteAttributeValue("", 3151, "/Carros/DeletarCarroIndex/", 3151, 26, true);
#nullable restore
#line 63 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
WriteAttributeValue("", 3177, carros.Id, 3177, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                        </td>\r\n                        <br>\r\n                    </tr>\r\n");
#nullable restore
#line 67 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n</div>\r\n\r\n");
#nullable restore
#line 74 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
 foreach (var carros in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-sm"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">");
#nullable restore
#line 80 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                                   Write(carros.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Fechar\"><span aria-hidden=\"true\">&times;</span></button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <td><strong>Placa - </strong>");
#nullable restore
#line 84 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                                        Write(carros.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><br>\r\n                <td><strong>Modelo - </strong>");
#nullable restore
#line 85 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                                         Write(carros.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><br>\r\n                <td><strong>Cor - </strong>");
#nullable restore
#line 86 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                                      Write(carros.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><br>\r\n                <td><strong>Preço - </strong>");
#nullable restore
#line 87 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
                                        Write(carros.Preco.ToString("F2", CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-dark\" data-dismiss=\"modal\"><strong>Fechar</strong></button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 95 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarWebMVC.Models.Carro>> Html { get; private set; }
    }
}
#pragma warning restore 1591