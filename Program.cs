using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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


            Console.WriteLine("ejemplo de segundo commit");

            */




            /*
            Funciones misFunciones = new Funciones();
            int a = 10;
            int b = 20;

            Console.WriteLine($"Antes del intercambio: a = {a}, b = {b}");
            
            misFunciones.Intercambio(ref a, ref b); 
            
            Console.WriteLine($"Despues del intercambio: a = {a}, b = {b}");

            misFunciones.mostrarResultado(misFunciones.Suma(5, 7));


            int numero1 = 10;
            int numero2 = 20;
            int mayor = misFunciones.Mayor(numero1, numero2);
            Console.WriteLine($"El mayor entre {numero1} y {numero2} es: {mayor}");


            double salario = 5000;
            double nuevoSalario = misFunciones.AumentoSalarial(salario);
            Console.WriteLine($"El nuevo salario con aumento es: {nuevoSalario}");
            */

            Producto producto = new Producto(nombre: "Lechuga", precio: 10, stock: 100);
            Producto producto2 = new Producto(nombre: "Arroz", precio: 8, stock: 150);

            producto.MostrarInfo();
            producto2.MostrarInfo();
        }
    }
}
