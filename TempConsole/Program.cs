using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackTemp;

namespace TempConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            do
            {

                Console.Write("Ingrese el valor de la temperatura: ");
                double vTemp = double.Parse(Console.ReadLine());
                Console.Write("Ingrese F->Fahrenheit, C->Celcius, K->Kelvin, (EN MAYSUCULAS!): ");
                string vScale = Console.ReadLine();

                Temp temp = new Temp(vTemp, vScale);

                Console.WriteLine("A que escala desea pasar?");
                Console.Write("Ingrese F->Fahrenheit, C->Celcius, K->Kelvin, (EN MAYSUCULAS!): ");
                option = Console.ReadLine();

                if (option == "F")
                {
                    Console.WriteLine("La temperatura en Fahrenheit es: " + temp.ToFahrenheit());
                }
                else if (option == "C")
                {
                    Console.WriteLine("La temperatura en Celsius es: " + temp.ToCelsius());
                }
                else if (option == "K")
                {
                    Console.WriteLine("La temperatura en Kelvin es: " + temp.ToKelvin());
                }
                else
                {
                    Console.WriteLine("Valor ingresado no valido!");
                }
                Console.Write("Ingrese S->SALIR o T->SGUIR: ");
                option = Console.ReadLine();
                Console.Clear();

            } while (option != "S");
        }
    }
}
