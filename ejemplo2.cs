using System;

namespace Ejercicio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = 5;
            int nuero2 = 6;
            double numero3 = 2.57;
            double suma;
            suma = num1 + numero3;
            Console.WriteLine(suma);
            string valor1 = Console.ReadLine();
            Console.WriteLine("El numero introducido es: " + valor1);
            int valorint = Convert.ToInt32(valor1);
            Console.WriteLine(valorint);
            Console.ReadKey();
        }
    }
}