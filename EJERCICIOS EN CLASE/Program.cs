using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_EN_CLASE
{
    internal class Program
    {
        //EJERCICIO 1
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            else if (numero > 0)
            {
                Console.WriteLine("El número es positivo");
            }
            else
            {
                Console.WriteLine("El número es 0 ");

            }
            Console.ReadKey();


            //Ejercicio 2
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("entre");
            }
            else
            {
                Console.WriteLine("NO PUEDE ENTRAR");
            }
            Console.ReadKey();


            //EJERCICIO 3

            Console.WriteLine("Ingrese su año de Nacimiento ");
            int año = int.Parse(Console.ReadLine());
            if (año >= 1928 && año <= 1945)
            {
                Console.WriteLine(" Usted pertenece a la generación silenciosa");

            }
            else if (año >= 1946 && año <= 1964)
            {
                Console.WriteLine(" Usted pertenece a la generación de los baby boome");
            }

            else if (año >= 1965 && año <= 1980)
            {
                Console.WriteLine(" Usted pertenece a la generación X");
            }
            else if (año >= 1981 && año <= 1996)
            {
                Console.WriteLine(" Usted pertenece a la generación de los millennials");

            }
            else if (año >= 1997 && año <= 2012)
            {
                Console.WriteLine(" Usted pertenece a la generación Z");
            }
            else if (año >= 2013)
            {
                Console.WriteLine(" Usted pertenece a la generación Alfa");
            }
            else
            {
                Console.WriteLine("Año inválido");
            }
            Console.ReadKey();


            //EJERCICO 4

            Console.WriteLine("Ingrese su año de Nacimiento ");
            año = int.Parse("2004");
            switch (año)
            {
                case >= 1928 and <= 1945:

                    Console.WriteLine(" Usted pertenece a la generación silenciosa");
                    break;
                case >= 1946 and <= 1964:

                    Console.WriteLine(" Usted pertenece a la generación baby bomme");
                    break;

                case >= 1965 and <= 1980:

                    Console.WriteLine(" Usted pertenece a la generación X");
                    break; 

                case >= 1981 and <= 1996:

                    Console.WriteLine(" Usted pertenece a la generación millenials");
                    break;

                case >= 1997 and <= 2012:

                    Console.WriteLine(" Usted pertenece a la generacion Z");
                    break;

                case >= 2013:

                    Console.WriteLine(" Usted pertenece a la generacion Alfa");
                    break;

                    Console.ReadKey();



                    //EJERCICO 5
                    String nombre, pais;
                    int edad;
                    char genero;

                    Console.WriteLine("Ingrese Nombre");
                    nombre= Console.ReadLine();

                    Console.WriteLine("Ingrese Nombre");
                    edad = Convert.ToInt32 (Console.ReadLine());

                    Console.WriteLine("Ingrese pais");
                    pais= Console.ReadLine();

                    Console.WriteLine("Ingrese genero: (m o f)");
                    genero= char.Parse(Console.ReadLine().ToUpper());


                    if (!nombre.StartsWith("A") && (edad >= 18 || genero == 'F')
                        && (pais == "GUATEMALA" || pais == "MEXICO"))
                        {
                        Console.WriteLine("Ud. cumple con los requisitos");
                    }
                    else
                        {
                        Console.WriteLine("no admitir");
                    }
                    






            }
        }
        }
    }

