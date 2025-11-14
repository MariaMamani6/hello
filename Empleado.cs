using System;

public class Empleado
{
    public string Nombre { get; set; }
    public string Cargo { get; set; }
    public double Sueldo { get; set; }

    public Empleado(string nombre, string cargo, double sueldo)
    {
        Nombre = nombre;
        Cargo = cargo;
        Sueldo = sueldo;
    }

    public double CalcularBono(double porcentaje)
    {
        double bono = Sueldo * (porcentaje / 100.0);
        return bono;
    }
}