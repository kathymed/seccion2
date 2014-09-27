using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppValorEntero
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un valor entero entre 1 y 5. 
             * Luego mostrar en español el valor ingresado.
             * Si se ingresa un valor fuera de dicho rango mostrar 
             * un mensaje indicando tal situación*/
            string numero, num;
            Console.WriteLine("Programa que pasa de numero a caracter");
            Console.WriteLine("Escriba un numero de 1 a 5 en letras");
            numero = Console.ReadLine();
            num=numero.ToLower();
            switch (num)
            {
                case "1":
                    Console.WriteLine("UNO");
                    break;
                case "2":
                    Console.WriteLine("DOS");
                    break;
                case "3":
                    Console.WriteLine("TRES");
                    break;
                case "4":
                    Console.WriteLine("CUATRO");
                    break;
                case "5":
                    Console.WriteLine("CINCO");
                    break;
                default:
                    Console.WriteLine("NUMERO FUERA DE RANGO");
                    break;
            }
            Console.ReadKey();
        }
        }
    }

