using System;

namespace EJERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 5");
            Console.WriteLine("Un estudiante tiene 6 materias con sus calificaciones del semestre, diseña un programa que le ayude a saber su calificación");
            Console.Write("Considera que si obtiene 7.6 hasta 10 decir HAS APROBADO y de 0 hasta 7.5 decir HAS REPROBADO.");

            double cal1, cal2, cal3, cal4, cal5, cal6, prom;
            Console.WriteLine("");
            Console.WriteLine("..............................................................................................");
            {
                Console.WriteLine("Ingresa la calificació de MATEMÁTICAS: ");
                cal1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la calificació de EXPRESIÓN ORAL Y ESCRITA: ");
                cal2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la calificació de GEOGRAFÍA: ");
                cal3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la calificació de INGLÉS: ");
                cal4 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la calificació de BILOGÍA: ");
                cal5 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la calificación de ARTES");
                cal6 = double.Parse(Console.ReadLine());

                prom = (cal1 + cal2 + cal3 + cal4 + cal5 + cal6) / 6;
                Console.WriteLine("El promedio que obtuviste es de: " + prom);

                if (prom >= 7.6 && prom <= 10)
                {
                    Console.WriteLine("HAS APROBADO");
                }
                if (prom >= 1 && prom <= 7.5)
                {
                    Console.WriteLine("HAS REPROBADO" + "\n");
                }
            }
            Console.WriteLine("..............................................................................");
            
            Console.ReadKey();

        }
    }
}
