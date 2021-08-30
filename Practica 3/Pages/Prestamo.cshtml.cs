using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_3.Pages
{
    public class PrestamoModel : PageModel
    {
        public void OnGet()
        {
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
