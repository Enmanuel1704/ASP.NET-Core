using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_3.Pages
{

    public class CajeroModel : PageModel
    {
        Dictionary<int, int> billetes;
        public CajeroModel()
        {
            billetes = new Dictionary<int, int>();
            billetes.Add(1000, 9);
            billetes.Add(500, 19);
            billetes.Add(100, 99);
        }
        public void OnGet()
        {

        }
        public void OnPost(string banco = "", int monto = 0)
        {
            if (monto % 100 != 0)
            {

                return;
            }
            switch (banco)
            {
                case "ABC":
                    if (monto <= 10000)
                    {

                    }
                    else if (monto > 10000)
                    {

                    }
                    else
                    {

                    }
                    break;
                default:
                    break;
            }

        }
        private Dictionary<int, int> dispensarBilletes(int monto)
        {
            Dictionary<int, int> auxbilletes = new Dictionary<int, int>(billetes);
            
            var retiro = new Dictionary<int, int>();
            if (monto >= 1000)
            {
                retiro.Add(1000, 0);
                int cantidad1000 = monto / 1000;
                if (cantidad1000 <= billetes[1000])
                {
                    monto -= cantidad1000 * 1000;
                    retiro[1000] = cantidad1000;
                    billetes[1000] -= cantidad1000;
                }
                else
                {
                    monto -= billetes[1000] * 1000;
                    retiro[1000] = billetes[1000];
                    billetes[1000] -= billetes[1000];
                }

            }

            if (monto >= 500)
            {
                retiro.Add(500, 0);
                int cantidad500 = monto / 500;
                if (cantidad500 <= billetes[500])
                {
                    monto -= cantidad500 * 500;
                    retiro[500] = cantidad500;
                    billetes[500] -= cantidad500;
                }
                else
                {
                    monto -= billetes[500] * 500;
                    retiro[500] = billetes[500];
                    billetes[500] -= billetes[500];
                }

            }

            if (monto >= 100)
            {
                retiro.Add(100, 0);
                int cantidad500 = monto / 100;
                if (cantidad500 <= billetes[500])
                {
                    monto -= cantidad500 * 100;
                    retiro[100] = cantidad500;
                    billetes[100] -= cantidad500;
                }
                else
                {
                    monto -= billetes[100] * 100;
                    retiro[100] = billetes[100];
                    billetes[100] -= billetes[100];
                }

            }



            return retiro;
        }
    }
}
