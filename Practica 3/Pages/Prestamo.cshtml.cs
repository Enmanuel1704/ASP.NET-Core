using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica_5;
using Practica_4;

namespace Practica_3.Pages
{
    public class PrestamoModel : PageModel
    {
        public void OnGet()
        {
            var numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numeros.Pares().Print(p => p.Select(x => x.ToString()));
            
        }
        public void OnPost(double monto=0, int cuotas=0, double interes=0)
        {
            if (monto > 0 && cuotas > 0 && interes > 0)
            {
                double pagarPorCuota = monto / cuotas;
                double InteresPorCuota = pagarPorCuota * interes / 100;

                // double totalPorCuota = pagarPorCuota + InteresPorCuota;


                ViewData["pagarPorCuota"] = pagarPorCuota;
                ViewData["InteresPorCuota"] = InteresPorCuota;
                ViewData["Cuotas"] = cuotas;

            }
        }

    }
}
