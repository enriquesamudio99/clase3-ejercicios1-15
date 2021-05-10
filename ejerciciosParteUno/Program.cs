using System;

namespace ejerciciosParteUno
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-) Mostrar los números impares entre el 0 y el 100
            //Console.WriteLine("Mostrar los números impares entre el 0 y el 100");
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine("{0} es impar", i);
            //    }
            //}
            // Fin Ejercicio 1

            // 2-) Mostrar los números pares entre el 0 y el 100
            //Console.WriteLine("Mostrar los números pares entre el 0 y el 100");
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("{0} es par", i);
            //    }
            //}
            // Fin Ejercicio 2

            // 3-) Mostrar los números del 0 al 100
            //Console.WriteLine("Mostrar los números del 0 al 100");
            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine("Numero: {0}", i);
            //}
            // Fin Ejercicio 3

            // 4-) Mostrar los números del 100 al 0
            //Console.WriteLine("Mostrar los números del 100 al 0");
            //for (int i = 100; i >= 0; i--)
            //{
            //    Console.WriteLine("Numero: {0}", i);
            //}
            // Fin Ejercicio 4

            // 5-) Mostrar los múltiplos de 3 y de 2 entre el 0 y 100
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 2 == 0)
            //    {
            //        Console.WriteLine("{0} es múltiplo de 3 y de 2", i);
            //    } else if(i % 3 == 0)
            //    {
            //        Console.WriteLine("{0} es múltiplo de 3", i);
            //    } else if(i % 2 == 0)
            //    {
            //        Console.WriteLine("{0} es múltiplo de 2", i);
            //    }
            //}
            // Fin Ejercicio 5

            // 6-) Ingresar un número y mostrar la suma de los números que lo anteceden. 
            Console.WriteLine("Ingrese un numero: ");
            int numeroIngresado = Convert.ToInt32(Console.ReadLine());
            int sumaAnteriores = 0;
            for (int i = numeroIngresado - 1; i >= 1; i--)
            {
                sumaAnteriores += i;
            }
            Console.WriteLine("La suma de los números que lo anteceden es {0}", sumaAnteriores);
            // Fin Ejercicio 6
        }
    }
}
