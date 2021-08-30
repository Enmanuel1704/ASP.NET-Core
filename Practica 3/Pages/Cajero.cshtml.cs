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
        public static Dictionary<int, int> billetes;
        public CajeroModel()
        {
        }
        public void OnGet()
        {
            billetes = new Dictionary<int, int>();
            billetes.Add(1000, 9);
            billetes.Add(500, 19);
            billetes.Add(100, 99);
        }
        public void OnPost(string banco = "", int monto = 0)
        {
            if (monto % 100 != 0 || monto < 100)
            {
                ViewData["mensaje"] = "El monto a retirar debe de ser multiplo de 100";
                return;
            }
            switch (banco)
            {
                case "ABC":
                    if (monto <= 10000)
                    {
                      ViewData["retirado"]= dispensarBilletes(monto);
                    }
                    else
                    {
                        ViewData["mensaje"] = "solo puede retirar 10,000 por persona del banco ABC ";
                    }
                    break;
                default:
                    if (monto <= 2000)
                    {
                        ViewData["retirado"] = dispensarBilletes(monto);
                    }
                    else
                    {
                        ViewData["mensaje"] = "solo puede retirar 2,000 por persona del banco "+banco;
                    }
                    break;
            }

        }
        private Dictionary<int, int> dispensarBilletes(int monto)
        {
            Dictionary<int, int> auxbilletes = new Dictionary<int, int>(billetes);
            
            var retiro = new Dictionary<int, int>();
            if (monto >= 1000 && auxbilletes[1000] > 0)
            {
                retiro.Add(1000, 0);
                int cantidad1000 = monto / 1000;
                if (cantidad1000 <= auxbilletes[1000])
                {
                    monto -= cantidad1000 * 1000;
                    retiro[1000] = cantidad1000;
                    auxbilletes[1000] -= cantidad1000;
                }
                else
                {
                    monto -= auxbilletes[1000] * 1000;
                    retiro[1000] = auxbilletes[1000];
                    auxbilletes[1000] -= auxbilletes[1000];
                }

            }

            if (monto >= 500 && auxbilletes[500] > 0)
            {
                retiro.Add(500, 0);
                int cantidad500 = monto / 500;
                if (cantidad500 <= auxbilletes[500])
                {
                    monto -= cantidad500 * 500;
                    retiro[500] = cantidad500;
                    auxbilletes[500] -= cantidad500;
                }
                else
                {
                    monto -= auxbilletes[500] * 500;
                    retiro[500] = auxbilletes[500];
                    auxbilletes[500] -= auxbilletes[500];
                }

            }

            if (monto >= 100 && auxbilletes[100] > 0)
            {
                retiro.Add(100, 0);
                int cantidad500 = monto / 100;
                if (cantidad500 <= auxbilletes[100])
                {
                    monto -= cantidad500 * 100;
                    retiro[100] = cantidad500;
                    auxbilletes[100] -= cantidad500;
                }
                else
                {
                    monto -= auxbilletes[100] * 100;
                    retiro[100] = auxbilletes[100];
                    auxbilletes[100] -= auxbilletes[100];
                }

            }

            if (monto == 0)
            {
                billetes = new Dictionary<int, int>(auxbilletes);
                return retiro;
            }
            else
            {
                ViewData["mensaje"] = "El cajero no tiene ese monto a retirar disponible";
                return null;
            }
            

        }
    }
}
