#pragma checksum "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc461fc8227d0864d122e85cda27be7e7f22337a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GAvicola.App.Frontend.Pages.Ambientes.Pages_Ambientes_Details1), @"mvc.1.0.razor-page", @"/Pages/Ambientes/Details1.cshtml")]
namespace GAvicola.App.Frontend.Pages.Ambientes
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
#line 1 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\_ViewImports.cshtml"
using GAvicola.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc461fc8227d0864d122e85cda27be7e7f22337a", @"/Pages/Ambientes/Details1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50db5fdd39138e190a3a1623e92f861aa96b3a48", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ambientes_Details1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddGalpones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddOperarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./index1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Detalle Variables de Ambiente</h1>\r\n<table class=\"table table-stried\">\r\n    <tr>\r\n        <th scope=\"col\">Id</th>\r\n        <td>");
#nullable restore
#line 9 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
       Write(Model.gambiente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Temperatura - ??C</th>\r\n        <td>");
#nullable restore
#line 13 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
       Write(Model.gambiente.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Agua - litros</th>\r\n        <td>");
#nullable restore
#line 17 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
       Write(Model.gambiente.Agua);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Alimento - Kg</th>\r\n        <td>");
#nullable restore
#line 21 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
       Write(Model.gambiente.Alimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Huevos</th>\r\n        <td>");
#nullable restore
#line 25 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
       Write(Model.gambiente.Huevos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Animales enfermos</th>\r\n        <td>");
#nullable restore
#line 29 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
       Write(Model.gambiente.Enfermas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Fecha</th>\r\n        <td>");
#nullable restore
#line 33 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
       Write(Model.gambiente.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
    </tr>
    <!--
        Se quito el simbolo ARROBA anes de ""Model""
    <tr>
        <th scope=""col"">Veterinario Id</th>
        <td>Model.galpon.Veterinario</td>
    </tr>
    <tr>
        <th scope=""col"">Operario Id</th>
        <td>Model.galpon.Operario</td>
    </tr>
    <tr>
-->

    <!-- Falta antes de hacer esto, buscar si existe el
    -->
    
        <th scope=""col"">Galpon</th>
");
#nullable restore
#line 52 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
         if (Model.gambiente.Galpon == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th> \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc461fc8227d0864d122e85cda27be7e7f22337a7252", async() => {
                WriteLiteral("Asignar Galpon");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
                                                                         WriteLiteral(Model.gambiente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <!--\r\n            <th>Nombre</th>\r\n            <td>Model.galpon.Veterinario</td>\r\n            -->\r\n");
#nullable restore
#line 61 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Quite el ARROBA anes de \"Model\"-->\r\n            <td>");
#nullable restore
#line 65 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
           Write(Model.gambiente.Galpon.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 66 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n    <tr>\r\n\r\n        <th scope=\"col\">Operario</th>\r\n");
#nullable restore
#line 71 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
         if (Model.gambiente.Operario == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <th>              \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc461fc8227d0864d122e85cda27be7e7f22337a10799", async() => {
                WriteLiteral("Asignar Operario");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
                                                                          WriteLiteral(Model.gambiente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n");
#nullable restore
#line 76 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Quite el ARROBA anes de \"Model\"-->\r\n            <td>");
#nullable restore
#line 80 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
           Write(Model.gambiente.Operario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 81 "C:\GAvicola\GAvicola.App\GAvicola.App.Frontend\Pages\Ambientes\Details1.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tr>\r\n    \r\n\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc461fc8227d0864d122e85cda27be7e7f22337a13905", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GAvicola.App.Frontend.Pages.Ambientes.Details1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GAvicola.App.Frontend.Pages.Ambientes.Details1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GAvicola.App.Frontend.Pages.Ambientes.Details1Model>)PageContext?.ViewData;
        public GAvicola.App.Frontend.Pages.Ambientes.Details1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
