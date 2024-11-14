using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    internal class Citautil
    {
        public static void Crear(List<Cita> citas)
        {
            Console.Write("Ingrese el número de la cita: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el código del estudiante: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la universidad: ");
            string universidad = Console.ReadLine();

            Estudiante estudiante = new Estudiante(codigo, nombre, universidad);

            Console.Write(" enfermedad: ");
            string enfermedad = Console.ReadLine();

            Console.Write("Ingrese el precio de la consulta (EN SOLES) ");
            double precio = double.Parse(Console.ReadLine());

            Cita cita = new Cita(numero, estudiante, enfermedad, precio);
            citas.Add(cita);

            Console.WriteLine("Cita creada ");
        }

        public static void Listar(List<Cita> citas)
        {
            double sumaTotal = 0;

            Console.WriteLine("\n--- Lista de Citas ---");
            foreach (Cita cita in citas)
            {
                Console.WriteLine(cita);
                sumaTotal += cita.Precio;
            }

            Console.WriteLine($"Suma total de precios: {sumaTotal:C}");
        }

        public static void ModificarUniversidad(List<Cita> citas)
        {
            Console.Write("Ingrese el texto a buscar en las universidades: ");
            string buscar = Console.ReadLine();

            Console.Write("Ingrese el nuevo texto para reemplazar: ");
            string reemplazar = Console.ReadLine();

            foreach (Cita cita in citas)
            {
                if (cita.Estudiante.Universidad.Contains(buscar))
                {
                    cita.Estudiante.Universidad = cita.Estudiante.Universidad.Replace(buscar, reemplazar);
                }
            }

            Console.WriteLine("Modificación masiva realizada con éxito.\n");
        }
    }
}
