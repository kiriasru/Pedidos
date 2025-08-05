using System.Threading.Channels;

namespace Pedidos.Herencia;

public class Libro : Producto
{
    // Atributos
    public string ISBN { get; set; }
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }
    
    // Metodos

    public override void MostrarInformacion()
    {
        Console.WriteLine();
        Console.WriteLine("***** DATOS DEL PRODUCTO *****");
        Console.WriteLine(ObtenerInformacionDetallada());
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
    } // Fin de MostrarInformacion
    
} // Fin de class