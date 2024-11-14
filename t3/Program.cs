// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using t3;

namespace CitasMedicasEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cita> citas = new List<Cita>();
            int opcion;

            do
            {
                Console.WriteLine("Opciones");
                Console.WriteLine("1 Crear Cita");
                Console.WriteLine("2 Listar Citas");
                Console.WriteLine("3 Modificar Universidad de Estudiantes");
                Console.WriteLine("4 Fin");
                Console.Write("Elija una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Citautil.Crear(citas);
                        break;
                    case 2:
                        Citautil.Listar(citas);
                        break;
                    case 3:
                        Citautil.ModificarUniversidad(citas);
                        break;
                    case 4:
                        Console.WriteLine("Fin del programa :).");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente  :(((((.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}

