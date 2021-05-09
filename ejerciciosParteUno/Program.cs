using System;

namespace ejerciciosParteUno
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-) Mostrar los números impares entre el 0 y el 100
            Console.WriteLine("Mostrar los números impares entre el 0 y el 100");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0} es impar", i);
                }
            }
        }
    }
}
