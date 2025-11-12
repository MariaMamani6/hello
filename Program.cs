using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cómo te llamas?");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡Hola, " + nombre + "!");

            
            DateTime fecha = DateTime.Now;
            Console.WriteLine("Hoy es " + fecha.ToString("dd/MM/yyyy"));

            Console.WriteLine("Ingrese número 1:");
            string a = Console.ReadLine();

            Console.WriteLine("Ingrese número 2:");
            string b = Console.ReadLine();

            int suma = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine("El resultado de la suma es: " + suma);
        }
    }
}
