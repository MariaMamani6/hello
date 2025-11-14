using System;

public class Funciones
{
    public int cuadrado(int numero)
    {
        return numero * numero;
    }

    public void Intercambio(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public int Suma(int x, int y)
    {
        return x + y;
    }

    public void mostrarResultado(int resultado)
    {
        Console.WriteLine("Suma " + resultado);
    }


    public int Mayor(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    public double AumentoSalarial(double salario)
    {
        return salario * 1.10; 
    }


}
