using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    public static class MetodosExtendidos
    {
        public static List<int> Pares(this List<int> lista)
        //=> lista.FindAll(p => p%2 == 0); //En landa expresion
        {
            return lista.FindAll(delegate (int x) { return x % 2 == 0; }); 
        }
    }
}
