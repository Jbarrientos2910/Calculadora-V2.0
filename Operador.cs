using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_v2._0
{
    internal class Operador : Numeros
    {

        public Operador() 
        {
        }

        public void CalcularSuma( int numero1 , int numero2 )
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;

            this.Resultado = this.Numero1 + this.Numero2;

            Console.Clear();
            Console.WriteLine("Usted eligio la operación SUMA");
            Console.WriteLine("1° Número: " + this.Numero1);
            Console.WriteLine("2° Número: " + this.Numero2);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("El resultado es: " + this.Resultado);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Presione ENTER para continuar...");
        }

        public void CalcularResta( int numero1 , int numero2)
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;

            this.Resultado = this.Numero1 - this.Numero2;

            Console.Clear();
            Console.WriteLine("Usted eligio la operación RESTA");
            Console.WriteLine("1° Número: " + this.Numero1);
            Console.WriteLine("2° Número: " + this.Numero2);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("El resultado es: " + this.Resultado);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Presione ENTER para continuar...");
        }

        public void CalcularProducto( int numero1 , int numero2)
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;

            this.Resultado = this.Numero1 * this.Numero2;

            Console.Clear();
            Console.WriteLine("Usted eligio la operación MULTIPLICACIÓN");
            Console.WriteLine("1° Número: " + this.Numero1);
            Console.WriteLine("2° Número: " + this.Numero2);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("El resultado es: " + this.Resultado);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Presione ENTER para continuar...");
        }

        public void CalcularDivision( int numero1 , int numero2)
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;

            this.Resultado = this.Numero1 / this.Numero2;

            Console.Clear();
            Console.WriteLine("Usted eligio la operación DIVISIÓN");
            Console.WriteLine("1° Número: " + this.Numero1);
            Console.WriteLine("2° Número: " + this.Numero2);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("El resultado es: " + this.Resultado);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Presione ENTER para continuar...");
        }

    }
}
