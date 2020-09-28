using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Empleados
{
    class Program
    {
        static Temporero temporero = new Temporero();
        static MedioTiempo medioTiempo = new MedioTiempo();
        static TiempoCompleto tiempoCompleto = new TiempoCompleto();
        static void Main(string[] args)
        {

            menu();

        }

        public static void menu()
        {
            int num;
            
            do
            {
                
                Console.WriteLine("Presione la tecla indicada para la creacion del tipo de empleado que desee" + "\n" +
                    "Creacion de empleado Temporero: 1" +
                    "\n" + "Creacion de empleado Madio Tiempo: 2"
                    + "\n" + "Creacion de empleado Tiempo Completo: 3");
                Console.WriteLine("Para mostrar el tipo de empleado deseado: 4");
                Console.WriteLine("Presione 0 si desea salir");
                Console.WriteLine();

                num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        temporero.crear_empleado();
                        break;
                    case 2:
                        medioTiempo.crear_empleado();
                        break;
                    case 3:
                        tiempoCompleto.crear_empleado();
                        break;
                    case 4:
                        mostrar();
                        break;
                }
            } while (num != 0);
       }

        public static void mostrar()
        {
           

            int num;
            Console.WriteLine("Presione el tipo de empleado que desea mostrar" +
                "\n" + "Temporero: 1" +
                "\n" + "Medio Tiempo: 2" +
                "\n" + "Tiempo Completo: 3");
            Console.WriteLine();
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    temporero.mostrar();                   
                    break;
                case 2:
                    medioTiempo.mostrar();
                    break;
                case 3:
                    tiempoCompleto.mostrar();
                    break;
            }
        }
    }
}
