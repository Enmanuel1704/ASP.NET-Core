using System;
using System.Collections.Generic;

namespace Practica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            foreach (var item in nums.Pares())
            {
                Console.WriteLine(item);
            }
        }
        public bool EsImpar(int x) // x => x%2 != 0
        {
            if (x % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public double CalcularITBIS(double precio) // p => p* 0.18
        {
            var itebis = precio * 0.18;
            return itebis;
        }


        public DateTime GetDate() // () => DateTime.Now
        {
            var fecha = DateTime.Now;
            return fecha;
        }
    }
}
