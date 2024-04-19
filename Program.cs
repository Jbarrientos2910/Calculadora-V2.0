using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_v2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int operacion;
            string opcion;
            Operador op1;

            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------- 0 ---------------------------");
                Console.WriteLine("Ingrese la operación que desea realizar");
                Console.WriteLine("1 = Suma / 2 = Resta / 3 = Multiplicación / 4 = División");
                operacion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("--------------------------- 0 ---------------------------");
                Console.WriteLine("Ingrese el primer número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                op1 = new Operador();

                if (operacion == 1)
                {
                    op1.CalcularSuma( numero1 , numero2 );
                    Console.ReadLine();
                }

                if (operacion == 2)
                {
                    op1.CalcularResta( numero1 , numero2 );
                    Console.ReadLine();
                }

                if (operacion == 3)
                {
                    op1.CalcularProducto( numero1 , numero2 );
                    Console.ReadLine();
                }

                if (operacion == 4)
                {
                    if(numero2 != 0)
                    {
                        op1.CalcularDivision(numero1, numero2);
                        Console.ReadLine();
                    } else {
                        Console.Clear();
                        Console.WriteLine("--------------------------- 0 ---------------------------");
                        Console.WriteLine("No se puede dividir por 0");
                        Console.WriteLine("--------------------------- 0 ---------------------------");
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();
                    }
                }

                if ( operacion > 4 || operacion < 1 )
                {
                    Console.WriteLine("--------------------------- 0 ---------------------------");
                    Console.WriteLine("La opción ingresada no es válida.");
                    Console.WriteLine("--------------------------- 0 ---------------------------");
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                }

                Console.Clear();
                Console.WriteLine("--------------------------- 0 ---------------------------");
                Console.WriteLine("¿Desea realizar otra operacion? [s/n]");
                Console.WriteLine("Ingrese su opcion: ");
                opcion = Console.ReadLine();
                if (opcion == "N" || opcion == "n")
                {
                    break;
                }

            } while (true);
        }
    }
}
