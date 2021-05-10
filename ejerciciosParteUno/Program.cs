using System;

namespace ejerciciosParteUno
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-) Mostrar los números impares entre el 0 y el 100
            Console.WriteLine("====================================================================");
            Console.WriteLine("==  Ejercicio 1: Mostrar los números impares entre el 0 y el 100  ==");
            Console.WriteLine("====================================================================");
            for (int i = 0; i <= 100; i++)
            {
                if (i != 0)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine("{0} es impar", i);
                    }
                }
            }
            // Fin Ejercicio 1
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 2-) Mostrar los números pares entre el 0 y el 100
            Console.WriteLine("=================================================================");
            Console.WriteLine("== Ejercicio 2: Mostrar los números pares entre el 0 y el 100  ==");
            Console.WriteLine("=================================================================");
            for (int i = 0; i <= 100; i++)
            {
                if (i != 0)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0} es par", i);
                    }
                }               
            }
            // Fin Ejercicio 2
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 3-) Mostrar los números del 0 al 100
            Console.WriteLine("=====================================================");
            Console.WriteLine("==  Ejercicio 3: Mostrar los números del 0 al 100  ==");
            Console.WriteLine("=====================================================");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Numero: {0}", i);
            }
            // Fin Ejercicio 3
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 4-) Mostrar los números del 100 al 0
            Console.WriteLine("=====================================================");
            Console.WriteLine("==  Ejercicio 4: Mostrar los números del 100 al 0  ==");
            Console.WriteLine("=====================================================");
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine("Numero: {0}", i);
            }
            // Fin Ejercicio 4
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 5-) Mostrar los múltiplos de 3 y de 2 entre el 0 y 100
            Console.WriteLine("=======================================================================");
            Console.WriteLine("==  Ejercicio 5: Mostrar los múltiplos de 3 y de 2 entre el 0 y 100  ==");
            Console.WriteLine("=======================================================================");
            for (int i = 0; i <= 100; i++)
            {
                if (i != 0)
                {
                    if (i % 3 == 0 && i % 2 == 0)
                    {
                        Console.WriteLine("{0} es múltiplo de 3 y de 2", i);
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("{0} es múltiplo de 3", i);
                    }
                    else if (i % 2 == 0)
                    {
                        Console.WriteLine("{0} es múltiplo de 2", i);
                    }
                }
            }
            // Fin Ejercicio 5
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 6-) Ingresar un número y mostrar la suma de los números que lo anteceden. 
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("==  Ejercicio 6: Ingresar un número y mostrar la suma de los números que lo anteceden.  ==");
            Console.WriteLine("==========================================================================================");
            Console.Write("Ingrese un numero: ");
            int seisNumeroIngresado = Convert.ToInt32(Console.ReadLine());
            int seisSumaAnteriores = 0;
            for (int i = seisNumeroIngresado - 1; i >= 1; i--)
            {
                seisSumaAnteriores += i;
            }
            Console.WriteLine("La suma de los números que lo anteceden es {0}", seisSumaAnteriores);
            // Fin Ejercicio 6
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 7-) Mostrar los números del 1 hasta el número ingresado.
            Console.WriteLine("=========================================================================");
            Console.WriteLine("==  Ejercicio 7: Mostrar los números del 1 hasta el número ingresado.  ==");
            Console.WriteLine("=========================================================================");
            Console.Write("Ingrese un numero: ");
            int sieteNumeroIngresado = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sieteNumeroIngresado; i++)
            {
                Console.WriteLine("Número: {0}", i);
            }
            // Fin Ejercicio 7
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 8-) Contar los múltiplos de 3 desde la unidad hasta un número que ingresamos
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("==  Ejercicio 8: Contar los múltiplos de 3 desde la unidad hasta un número que ingresamos.  ==");
            Console.WriteLine("==============================================================================================");
            Console.Write("Ingrese un numero: ");
            int ochoNumeroIngresado = Convert.ToInt32(Console.ReadLine());
            int ochoMultiplosTres = 0;
            for (int i = 1; i <= ochoNumeroIngresado; i++)
            {
                if (i % 3 == 0)
                {
                    ochoMultiplosTres++;
                }              
            }
            Console.WriteLine("Se conto {0} múltiplo/s de 3 hasta el número {1}", ochoMultiplosTres, ochoNumeroIngresado);
            // Fin Ejercicio 8
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 9-) Mostrar los números primos entre el 0 y 100.
            Console.WriteLine("=================================================================");
            Console.WriteLine("==  Ejercicio 9: Mostrar los números primos entre el 0 y 100.  ==");
            Console.WriteLine("=================================================================");
            for (int num = 0; num <= 100; num++)
            {
                if (num > 1)
                {
                    int contador = 0;
                    int i = 2;
                    int resto = 0;

                    while ((i < num) && (contador == 0))
                    {
                        resto = num % i;
                        if (resto == 0)
                        {
                            contador++;
                        }
                        i++;
                    }

                    if (contador == 0)
                    {
                        Console.WriteLine("El {0} es un número primo", i);
                    }

                }
            }
            // Fin Ejercicio 9
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 10-) Ingresar dos números e intercambiarlos.
            Console.WriteLine("=============================================================");
            Console.WriteLine("==  Ejercicio 10: Ingresar dos números e intercambiarlos.  ==");
            Console.WriteLine("=============================================================");
            Console.Write("Ingrese un primer numero: ");
            int diezNumeroUno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un segundo numero: ");
            int diezNumeroDos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numeros ingresados: N° 1: {0}, N° 2: {1}", diezNumeroUno, diezNumeroDos);
            Console.WriteLine("Numeros intercambiados");
            int diezAux = diezNumeroUno;
            diezNumeroUno = diezNumeroDos;
            diezNumeroDos = diezAux;
            Console.WriteLine("El N° 1 es ahora el: {0}, y el N° 2 es ahora el: {1}", diezNumeroUno, diezNumeroDos);
            // Fin Ejercicio 10
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 11-) Ingresar un número y mostrar su cuadrado y cubo.
            Console.WriteLine("======================================================================");
            Console.WriteLine("==  Ejercicio 11: Ingresar un número y mostrar su cuadrado y cubo.  ==");
            Console.WriteLine("======================================================================");
            Console.Write("Ingrese un numero: ");
            int onceNumeroIngresado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El {0} elevado al cuadrado es {1}", onceNumeroIngresado, Math.Pow(onceNumeroIngresado, 2));
            Console.WriteLine("El {0} elevado al cubo es {1}", onceNumeroIngresado, Math.Pow(onceNumeroIngresado, 3));
            // Fin Ejercicio 11
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 12-) Ingresar dos números e indicar cuál es mayor y menor.
            Console.WriteLine("===========================================================================");
            Console.WriteLine("==  Ejercicio 12: Ingresar dos números e indicar cuál es mayor y menor.  ==");
            Console.WriteLine("===========================================================================");
            Console.Write("Ingrese un primer número: ");
            int doceNumeroUno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un segundo número: ");
            int doceNumeroDos = Convert.ToInt32(Console.ReadLine());
            if (doceNumeroUno == doceNumeroDos)
            {
                Console.WriteLine("Son iguales");
            }
            else if (doceNumeroUno > doceNumeroDos)
            {
                Console.WriteLine("El primer número es mayor");
            }
            else
            {
                Console.WriteLine("El segundo número es mayor");
            }
            // Fin Ejercicio 12
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 13-) Ingresar dos números y mostrar la suma, la resta, la multiplicación, la división y el residuo entre ambos.
            // Para la división, se deberá determinar cuál es el mayor.
            Console.WriteLine("================================================================================================================================");
            Console.WriteLine("==  Ejercicio 13: Ingresar dos números y mostrar la suma, la resta, la multiplicación, la división y el residuo entre ambos.  ==");
            Console.WriteLine("==  Para la división, se deberá determinar cuál es el mayor.                                                                  ==");
            Console.WriteLine("================================================================================================================================");
            Console.Write("Ingrese un primer numero: ");
            double treceNumeroUno = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese un segundo numero: ");
            double treceNumeroDos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La suma de ambos numeros es {0}", (treceNumeroUno + treceNumeroDos));
            Console.WriteLine("La resta de ambos numeros es {0}", (treceNumeroUno - treceNumeroDos));
            Console.WriteLine("La multiplicación de ambos numeros es {0}", (treceNumeroUno * treceNumeroDos));
            double treceDivision = 0;
            if (treceNumeroDos > treceNumeroUno)
            {
                treceDivision = treceNumeroDos / treceNumeroUno;
                Console.WriteLine("(El número mayor es el dividendo) La divisíon de ambos numeros es {0}", treceDivision);
            }
            else
            {
                treceDivision = treceNumeroUno / treceNumeroDos;
                Console.WriteLine("(El número mayor es el dividendo) La divisíon de ambos numeros es {0}", treceDivision);
            }
            Console.WriteLine("El residuo entre ambos numeros es {0}", (treceNumeroUno % treceNumeroDos));
            // Fin Ejercicio 13 
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 14-) Mostrar las tablas de multiplicar del 1 al 10. Se debe ver de esta manera: 1 x 1 = 1.
            Console.WriteLine("===========================================================================================================");
            Console.WriteLine("==  Ejercicio 14: Mostrar las tablas de multiplicar del 1 al 10. Se debe ver de esta manera: 1 x 1 = 1.  ==");
            Console.WriteLine("===========================================================================================================");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Tabla del {0}", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, (i * j));
                }
            }
            // Fin Ejercicio 14
            Console.Write("Siguiente ejercicio");
            Console.ReadLine();

            // 15-) Mostrar la tabla de multiplicar de un número ingresado por el usuario.
            Console.WriteLine("============================================================================================");
            Console.WriteLine("==  Ejercicio 15: Mostrar la tabla de multiplicar de un número ingresado por el usuario.  ==");
            Console.WriteLine("============================================================================================");
            Console.Write("Ingrese el numero del que desea ver la tabla de multiplicar: ");
            int quinceNumeroIngresado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tabla del {0}", quinceNumeroIngresado);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", quinceNumeroIngresado, i, (quinceNumeroIngresado * i));
            }
            // Fin Ejercicio 15 
            Console.ReadLine();
        }
    }
}
