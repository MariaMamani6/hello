using System;

class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int stock { get; set; }

    public Producto(string nombre, decimal precio, int stock)
    {
        Nombre = nombre;
        Precio = precio;
        this.stock = stock;

    }

    public void MostrarInfo()

    {
        Console.WriteLine("Producto: " + Nombre + ", Precio: $ " + Precio + " , stock: " + stock);
    }

    public void ActualizarStock(int cantidad)
    {
        this.stock += cantidad; 
        Console.WriteLine($"Stock de '{Nombre}' actualizado. Nuevo stock: {this.stock}");
    }
}