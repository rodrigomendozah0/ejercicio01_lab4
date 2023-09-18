using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 16;
            int numero2 = 5;
            int resultado = 0;

            for (int i = 0; i < numero2; i++)
            {
                resultado = resultado + numero1;
            }

            Console.WriteLine("El resultado de esta multplicación es: " + resultado);
            Console.ReadKey();
        }
    }
}
