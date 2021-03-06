#pragma checksum "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffc3ee22ba05eb6d438c8c55d275768e4d6b0dbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Practica_2.Pages.Pages_Nomina), @"mvc.1.0.razor-page", @"/Pages/Nomina.cshtml")]
namespace Practica_2.Pages
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
#line 1 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\_ViewImports.cshtml"
using Practica_2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffc3ee22ba05eb6d438c8c55d275768e4d6b0dbb", @"/Pages/Nomina.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3434ff39f83feb11b5370c1d456a5020cc46978a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Nomina : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div>
   
    


    <table class=""table"">
        <thead>
            <tr>
                <th>Nombres</th>
                <th>Apellidos</th>
                <th>Cargo</th>
                <th>Salario Mensual</th>
                <th>Descuento AFP</th>
                <th>Descuento ARS</th>
                <th>Descuento ISR</th>
                <th>Total de descuentos</th>
                <th>Salario Neto</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
             foreach (Empleado empleado in Model.empleados)
            {
                double ars = empleado.salario * 0.0304;
                ars = ((ars >= 4098.53) ? 4098.53 : ars);
                double afp = empleado.salario * 0.0287;
                afp = ((afp >= 7738.67) ? 7738.67 : afp);
                double Irs = Math.Round( (empleado.salario*12 >= 867123.01) ? ((empleado.salario *12 - 867123.01) * 0.25 + 79776.00)/12 :
                             (empleado.salario*12 >= 624329.01) ? ((empleado.salario *12 - 624329.01) * 0.20 + 31216.00)/12 :
                             (empleado.salario*12 >= 416220.01) ? ((empleado.salario*12 - 416220.01) * 0.15)/12 : 0 ,2);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
               Write(empleado.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
               Write(empleado.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
               Write(empleado.cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
               Write(empleado.salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
               Write(afp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
               Write(ars);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
               Write(Irs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
                Write(afp+ars+Irs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
                Write(empleado.salario-(afp + ars + Irs));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\MIDEREC\Desktop\Practica1-ASP.NET-Core\Practica 2\Pages\Nomina.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Practica_2.Pages.NominaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Practica_2.Pages.NominaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Practica_2.Pages.NominaModel>)PageContext?.ViewData;
        public Practica_2.Pages.NominaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
