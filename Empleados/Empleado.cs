using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados
{
   abstract class Empleado
    {
        public int codigo;
        public string nombre;
        public string departamento;
        public string cargo;
        public int horas_laboradas;
        public int precio_hora;
        public string tipo_cobro;      

        public void Ponchar(int code, string name) 
        {
            Console.WriteLine("Codigo: " + code);
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Hora de ponche: " + DateTime.Now);
        }

        public virtual void trabajar(int id)
        {
            Console.WriteLine("El usuario " + id + " esta trabajando!");
            Console.WriteLine();
        }

        public void cobrar(int horas_laboradas, int precio_hora)
        {
            int salario = horas_laboradas * precio_hora;
            Console.WriteLine("Sueldo: " + salario + " $");
            Console.WriteLine();
        }
    }
}
