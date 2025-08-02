namespace Pedidos.Herencia;

public class Electronico : Producto
{
    // Atributos
    public int GarantiaMeses { get; set; }
    public string Voltaje { get; set; }
    
    // Metodos
    public override void MostrarInformacion()
    {
        Console.WriteLine();
        Console.WriteLine("***** DATOS DEL PRODUCTO *****");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: {Precio:C}");
        Console.WriteLine($"Cantidad disponible: {Stock}");
        Console.WriteLine($"Garantia: {GarantiaMeses} meses");
        Console.WriteLine($"Voltaje: {Voltaje}");
    } // Fin del override
    
} // Fin de class