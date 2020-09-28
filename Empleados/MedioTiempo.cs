using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Empleados
{
    class MedioTiempo : Empleado
    {

        public string tipo_empleado = "Empleado medio tiempo";
        List<MedioTiempo> medioTiempos = new List<MedioTiempo>();

        public void crear_empleado()
        {
            Console.WriteLine("Creacion de empleado medio tiempo");
            int id = medioTiempos.Count;

            medioTiempos.Add(new MedioTiempo());
            medioTiempos[id].codigo = 101 + id;
            medioTiempos[id].tipo_cobro = "Cobro por cheque";

            Console.WriteLine("Digite el nombre del empleado");
            medioTiempos[id].nombre = Console.ReadLine();

            Console.WriteLine("Digite el departamento");
            medioTiempos[id].departamento = Console.ReadLine();

            Console.WriteLine("Digite el cargo");
            medioTiempos[id].cargo = Console.ReadLine();

            Console.WriteLine("Digite las horas laboradas");
            medioTiempos[id].horas_laboradas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el precio por hora");
            medioTiempos[id].precio_hora = Convert.ToInt32(Console.ReadLine());
            medioTiempos[id].tipo_cobro = "Cobro por cuenta bancaria";

        }

        public void mostrar()
        {
            foreach (MedioTiempo m in medioTiempos)
            {
                Console.WriteLine(m.nombre + ": " + m.codigo +
                    "\n" + "Departamento: " + m.departamento +
                    "\n" + "Cargo: " + m.cargo +
                    "\n" + "Horas laboradas: " + m.horas_laboradas +
                    "\n" + "Precio por hora: " + m.precio_hora);
                cobrar(m.horas_laboradas, m.precio_hora);
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
                int index = medioTiempos.IndexOf(medioTiempos.Where(t => t.codigo == id).FirstOrDefault());
                Ponchar(id, medioTiempos[index].nombre);
            }
        }
        public void eliminar_empleado(int id)
        {
            medioTiempos.RemoveAt(id - 101);
        }
    }
}
