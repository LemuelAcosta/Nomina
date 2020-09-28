using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Empleados
{
    class TiempoCompleto : Empleado
    {
        public string tipo_empleado = "Empleado tiempo completo";
        List<TiempoCompleto> tiempoCompletos = new List<TiempoCompleto>();

        public void crear_empleado()
        {
            Console.WriteLine("Creacion de empleado tiempo completo");
            int id = tiempoCompletos.Count;

            tiempoCompletos.Add(new TiempoCompleto());
            tiempoCompletos[id].codigo = 101 + id;
            tiempoCompletos[id].tipo_cobro = "Cobro por cheque";

            Console.WriteLine("Digite el nombre del empleado");
            tiempoCompletos[id].nombre = Console.ReadLine();

            Console.WriteLine("Digite el departamento");
            tiempoCompletos[id].departamento = Console.ReadLine();

            Console.WriteLine("Digite el cargo");
            tiempoCompletos[id].cargo = Console.ReadLine();

            Console.WriteLine("Digite las horas laboradas");
            tiempoCompletos[id].horas_laboradas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el precio por hora");
            tiempoCompletos[id].precio_hora = Convert.ToInt32(Console.ReadLine());
            tiempoCompletos[id].tipo_cobro = "Cobro por cuenta bancaria";

        }
        public void mostrar()
        {
            foreach (TiempoCompleto t in tiempoCompletos)
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
            int i1 = Convert.ToInt32(Console.ReadLine());
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
                int index = tiempoCompletos.IndexOf(tiempoCompletos.Where(t => t.codigo == id).FirstOrDefault());
                Ponchar(id, tiempoCompletos[index].nombre);
            }
        }
        public void eliminar_empleado(int id)
        {
            tiempoCompletos.RemoveAt(id - 101);
        }
    }
}