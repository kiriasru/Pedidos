
namespace Pedidos
{
    public class Producto
    {
        // Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock {  get; set; }

        // Metodos
        public void MostrarInformacion()
        {
            Console.WriteLine("***** DATOS DEL PRODUCTO *****");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Cantidad disponible: {Stock}");
            Console.WriteLine();
        }

        // Si el constructor no lleva params, C# automaticamente los crea por detras
       
        // Terminar el constructor

        public void DisminuirStock(int Cantidad)
        {
            if (Stock >= Cantidad)
            {
                Stock -= Cantidad;
            }
            else
            {
                Console.WriteLine($"No hay suficiente stock de {Nombre}");
            }
        }
    } // Fin de Class
} // Fin de Pedidos
