using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonOutil
{
    internal class Meteo
    {
        public Meteo()
        {

            double tempEnCelsius;

            double tempEnFahrenheit;

            string? line;


            Console.WriteLine("Bienvenu à l'outil Meteo.");

            Console.WriteLine("Quel est la temperatur en celsius ? ");

            line = Console.ReadLine();

            tempEnCelsius = Convert.ToDouble(line);


            tempEnFahrenheit = (tempEnCelsius * 9) / 5 + 32;

            Console.WriteLine(tempEnCelsius + " Celsius = " + tempEnFahrenheit + " en fahrenheit");

        }
    }
}
