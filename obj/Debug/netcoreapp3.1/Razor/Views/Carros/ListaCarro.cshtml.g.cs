#pragma checksum "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d33fd76ca14cb5eafd74d12534139c9f7c3c2a52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carros_ListaCarro), @"mvc.1.0.view", @"/Views/Carros/ListaCarro.cshtml")]
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
#line 1 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33fd76ca14cb5eafd74d12534139c9f7c3c2a52", @"/Views/Carros/ListaCarro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6a543b1b54c86a2fdd477ae58c1fc4fb471293", @"/Views/_ViewImports.cshtml")]
    public class Views_Carros_ListaCarro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarWebMVC.Models.Carro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"sidebar\">\r\n    <a class=\"btn btn-success btn-xs\" href=\"/Carros/CadastrarCarro\" style=\"padding: 10px; font-size: medium; float: right\">Cadastrar carro</a>\r\n</div>\r\n\r\n<h2>Listagem dos carros</h2>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
 foreach (var carro in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n    <p><strong>Marca: </strong>");
#nullable restore
#line 16 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
                          Write(carro.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><strong>Modelo: </strong>");
#nullable restore
#line 17 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
                           Write(carro.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><strong>Cor: </strong>");
#nullable restore
#line 18 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
                        Write(carro.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><strong>Placa: </strong>");
#nullable restore
#line 19 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
                          Write(carro.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><strong>Preco: </strong>R$ ");
#nullable restore
#line 20 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
                             Write(carro.Preco.ToString("F2", CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 667, "\"", 703, 2);
            WriteAttributeValue("", 674, "/Carros/EditarCarro/", 674, 20, true);
#nullable restore
#line 21 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
WriteAttributeValue("", 694, carro.Id, 694, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Editar</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 744, "\"", 781, 2);
            WriteAttributeValue("", 751, "/Carros/DeletarCarro/", 751, 21, true);
#nullable restore
#line 22 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
WriteAttributeValue("", 772, carro.Id, 772, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Deletar</a><br>\r\n");
#nullable restore
#line 23 "C:\Users\jocm\My Private Documents\codes\Projeto MVC\carwebmvc\CarWebMVC\Views\Carros\ListaCarro.cshtml"
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
