using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Empleados
{
    class Temporero : Empleado
    {
        public string tipo_empleado = "Empleado temporero";
        public List<Temporero> temporeros = new List<Temporero>();


        public void crear_empleado()
        {
            Console.WriteLine("Creacion de empleado Temporero");
            int id = temporeros.Count;

            temporeros.Add(new Temporero());
            temporeros[id].codigo = 101 + id;
            temporeros[id].tipo_cobro = "Cobro por cheque";

            Console.WriteLine("Digite el nombre del empleado");
            temporeros[id].nombre = Console.ReadLine();

            Console.WriteLine("Digite el departamento");
            temporeros[id].departamento = Console.ReadLine();

            Console.WriteLine("Digite el cargo");
            temporeros[id].cargo = Console.ReadLine();

            Console.WriteLine("Digite las horas laboradas");
            temporeros[id].horas_laboradas = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("Digite el precio por hora");
            temporeros[id].precio_hora = Convert.ToInt32(Console.ReadLine());
            temporeros[id].tipo_cobro = "Cobro por cheque";
                
        }

        public void mostrar()
        {
         foreach(Temporero t in temporeros)
         {
                Console.WriteLine(t.nombre + ": " + t.codigo + 
                    "\n" + "Departamento: " + t.departamento + 
                    "\n" + "Cargo: " + t.cargo + 
                    "\n" + "Horas laboradas: " + t.horas_laboradas + 
                    "\n" + "Precio por hora: " + t.precio_hora);
                    cobrar(t.horas_laboradas, t.precio_hora);
                Console.WriteLine();
         }
            Console.WriteLine("OPCIONES" + "\n" +
                              "1. Eliminar usuario" + "\n" +
                              "2. Aplicar la funcion de trabajar a algun usuario" + "\n" +
                              "3. Aplicar la funcion de Ponchar a algun usuario");
            int i1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (i1 == 1)
            {
                Console.WriteLine("Escriba el ID del mismo ");
                int id = Convert.ToInt32(Console.ReadLine());
                eliminar_empleado(id);
                Console.WriteLine("USUARIO ELIMINADO");
                Console.WriteLine();
            }
            else if (i1 == 2)
            {
                Console.WriteLine("Escriba el ID del mismo ");
                int id = Convert.ToInt32(Console.ReadLine());
                trabajar(id);
            }
            else if (i1 == 3)
            {
                Console.WriteLine("Escriba el ID del mismo "); 
                int id = Convert.ToInt32(Console.ReadLine());
                int index = temporeros.IndexOf(temporeros.Where(t => t.codigo == id).FirstOrDefault());
                Ponchar(id, temporeros[index].nombre);
            }

        }
        public void eliminar_empleado(int id)
        {
            temporeros.RemoveAt(id - 101);
        }
    }
}
