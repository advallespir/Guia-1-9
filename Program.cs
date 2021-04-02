using System;

namespace Guia_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un texto para convertir en mayusculas");
            string texto = Console.ReadLine();
            string textoToUpper = texto.ToUpper(new System.Globalization.CultureInfo("es-ES", false));
            Console.WriteLine(textoToUpper);
            Console.ReadLine();

        }
    }
}
