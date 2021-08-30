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
        Dictionary<int, int> billetes ;
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
        public void OnPost(string banco ="", int monto=0)
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
        private Dictionary<int,int> dispensarBilletes(int monto)
        {

            int cantidad1000 = monto / 1000;
            if (cantidad1000 <= billetes[1000])
            {
                billetes[1000] -= cantidad1000;
                monto -= cantidad1000 * 1000;
            }
            else
            {
                billetes[1000] -= billetes[1000];
                monto -= billetes[1000] * 1000;
            }


            int cantidad500 = monto / 500;
            int cantidad100 = monto / 100;



            return
        }
    }
}
