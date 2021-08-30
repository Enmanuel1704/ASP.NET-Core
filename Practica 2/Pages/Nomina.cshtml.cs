using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_2.Pages
{
    public class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cargo { get; set; }
        public double salario { get; set; }
    }
    public class NominaModel : PageModel
    {
        public List<Empleado> empleados { get; set; } 

        public NominaModel()
        {
            empleados = new List<Empleado>();
        }

        public void OnGet()
        {
            empleados.Add(new Empleado() { nombre = "José", apellido = "Martinez", cargo = "Soporte", salario = 25000 });

            empleados.Add(new Empleado() { nombre = "María", apellido = "Gonzales", cargo = "Contable", salario = 50000 });

            empleados.Add(new Empleado() { nombre = "Ramóna", apellido = "Pérez", cargo = "Secretaria", salario = 18500 });

            empleados.Add(new Empleado() { nombre = "Francisco", apellido = "Mota", cargo = "Programador", salario = 125000 });

            empleados.Add(new Empleado() { nombre = "Ruby", apellido = "Martes", cargo = "Administrador", salario = 300000 });

        }
    }
}
