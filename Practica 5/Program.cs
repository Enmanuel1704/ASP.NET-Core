using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica_5
{
        public class Producto
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public int CategoriaID { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public double Precio { get; set; }
        }
        public class Categoria
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
        }
    class Program
    {

        static void Main(string[] args)
        {
            var productos = new List<Producto>()
            {
                new Producto() { ID = 1, CategoriaID = 5, Nombre = "Laptop", Marca = "DELL", Modelo = "Inspire", Precio = 15000 },
                new Producto() { ID = 2, CategoriaID = 1, Nombre = "Jean", Marca = "Leavis", Modelo = "32x32", Precio = 1500.99},
                new Producto() { ID = 3, CategoriaID = 1, Nombre = "Short", Marca = "Americans", Modelo = "30", Precio = 3200.89 },
                new Producto() { ID = 4, CategoriaID = 2, Nombre = "Tenis", Marca = "Nike", Modelo = "40", Precio = 3555.55 },
                new Producto() { ID = 5, CategoriaID = 3, Nombre = "Carolina", Marca = "Carolona Herrera", Modelo = "10oz", Precio = 4350.87 },
                new Producto() { ID = 6, CategoriaID = 5, Nombre = "CPU", Marca = "ASUS", Modelo = "KS809", Precio = 5000 },
                new Producto() { ID = 7, CategoriaID = 2, Nombre = "Sandalias", Marca = "Hawjanas", Modelo = "38", Precio = 3000 },
                new Producto() { ID = 8, CategoriaID = 4, Nombre = "Alienware", Marca = "DELL", Modelo = "HD22", Precio = 9500 },
                new Producto() { ID = 9, CategoriaID = 5, Nombre = "Teclado Mecanico", Marca = "Logiteth", Modelo = "qwerty", Precio = 2310.56 },
                new Producto() { ID = 10, CategoriaID = 5, Nombre = "Bocinas", Marca = "JBL", Modelo = "BD2000", Precio = 3333.33 }
            };
            var categorias = new List<Categoria>()
            {
                new Categoria() { ID = 1, Nombre = "Pantalones" },
                new Categoria() { ID = 2, Nombre = "Calzados" },
                new Categoria() { ID = 3, Nombre = "Perfumes" },
                new Categoria() { ID = 4, Nombre = "Monitores" },
                new Categoria() { ID = 5, Nombre = "Equipo Tecnológicos" }
            };


            var productosTec = from p in productos
                               where p.CategoriaID == 5
                               select p;

            var productos3000a5000 = from p in productos
                                     where p.Precio >= 3000 && p.Precio <= 5000
                                     orderby p.ID descending
                                     select p;

            var prodycategoria = from p in productos
                                 join c in categorias on p.CategoriaID equals c.ID
                                 select  c.Nombre ;


        }
    }
}
