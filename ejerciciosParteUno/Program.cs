﻿using System;

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
            //Console.WriteLine("Ingrese un numero: ");
            //int seisNumeroIngresado = Convert.ToInt32(Console.ReadLine());
            //int seisSumaAnteriores = 0;
            //for (int i = seisNumeroIngresado - 1; i >= 1; i--)
            //{
            //    seisSumaAnteriores += i;
            //}
            //Console.WriteLine("La suma de los números que lo anteceden es {0}", seisSumaAnteriores);
            // Fin Ejercicio 6

            // 7-) Mostrar los números del 1 hasta el número ingresado.
            //Console.WriteLine("Ingrese un numero: ");
            //int sieteNumeroIngresado = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= sieteNumeroIngresado; i++)
            //{
            //    Console.WriteLine("Número: {0}", i);
            //}
            // Fin Ejercicio 7

            // 8-) Contar los múltiplos de 3 desde la unidad hasta un número que ingresamos
            //Console.WriteLine("Ingrese un numero: ");
            //int ochoNumeroIngresado = Convert.ToInt32(Console.ReadLine());
            //int ochoMultiplosTres = 0;
            //for (int i = 1; i <= ochoNumeroIngresado; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        ochoMultiplosTres++;
            //    }
            //}
            //Console.WriteLine("Se conto {0} múltiplo/s de 3 hasta el número {1}", ochoMultiplosTres, ochoNumeroIngresado);
            // Fin Ejercicio 8

            // 9-) Mostrar los números primos entre el 0 y 100.
            //for (int num = 0; num <= 100; num++)
            //{
            //    if (num > 1)
            //    {
            //        int contador = 0;
            //        int i = 2;
            //        int resto = 0;

            //        while ((i < num) && (contador == 0))
            //        {
            //            resto = num % i;
            //            if (resto == 0)
            //            {
            //                contador++;
            //            }
            //            i++;
            //        }

            //        if (contador == 0)
            //        {
            //            Console.WriteLine("El {0} es un número primo", i);
            //        }

            //    }
            //}
            // Fin Ejercicio 9

            // 10-) Ingresar dos números e intercambiarlos.
            //Console.WriteLine("Ingrese un primer numero: ");
            //int diezNumeroUno = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese un segundo numero: ");
            //int diezNumeroDos = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Numeros ingresados: N° 1: {0}, N° 2: {1}", diezNumeroUno, diezNumeroDos);
            //Console.WriteLine("Numeros intercambiados");
            //int diezAux = diezNumeroUno;
            //diezNumeroUno = diezNumeroDos;
            //diezNumeroDos = diezAux;
            //Console.WriteLine("El N° 1 es ahora el: {0}, y el N° 2 es ahora el: {1}", diezNumeroUno, diezNumeroDos);
            // Fin Ejercicio 10

            // 11-) Ingresar un número y mostrar su cuadrado y cubo.
            //Console.WriteLine("Ingrese un numero: ");
            //int onceNumeroIngresado = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("El {0} elevado al cuadrado es {1}", onceNumeroIngresado, Math.Pow(onceNumeroIngresado, 2));
            //Console.WriteLine("El {0} elevado al cubo es {1}", onceNumeroIngresado, Math.Pow(onceNumeroIngresado, 3));
            // Fin Ejercicio 11


        }
    }
}
