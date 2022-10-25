using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realizar un programa que dado un operario se conoce su sueldo y los años de antigüedad.");
            Console.WriteLine("Realizar un programa que lea los datos de entrada e indicar:");
            Console.WriteLine("Si el sueldo es  menor  o igual a $10000 y su antigüedad es mayor o igual a 8 años, otorgarle un aumento del 25 %, mostrar el sueldo a pagar.");
            Console.WriteLine("Si el sueldo es mayor o igual a $10000 y su antigüedad es menor o igual a 7 años, otorgarle un aumento de 15 %.");
            Console.WriteLine("Si el sueldo es menor o igual a 90000 mostrar el sueldo.");
            Console.WriteLine(".............................................................................................................. \n ");

            double sueldo, sueldoT, aumento, total;
            int antiguedad;
            Console.WriteLine("Ingresa el sueldo del empleado");
            sueldo = double.Parse(Console.ReadLine());
            if (sueldo<=10000)   
            {
                Console.WriteLine("Ingresa los años del trabajo");
                antiguedad = int.Parse(Console.ReadLine());
                if (antiguedad>=8)
                {
                    aumento = sueldo * 0.25;
                    sueldoT = aumento;
                    total = sueldo + sueldoT;
                    Console.WriteLine("Aumento $ " + sueldoT);
                    Console.WriteLine("Sueldo total $" + total);
                }
                else if (antiguedad<=7)
                {
                    aumento = 10000 * 0.15;
                    sueldoT = aumento;
                    total = sueldo + sueldoT;
                    Console.WriteLine("Aumento $ " + sueldoT);
                    Console.WriteLine("Sueldo total $" + total);
                }
            }
            else if (sueldo<=9000)
            {
                Console.WriteLine("El sueldo a pagar es de : $ " + sueldo);
            }
            Console.ReadKey();
        }
    }
}
