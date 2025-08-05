
using Pedidos.Herencia;

namespace Pedidos
{
    public class Pedido : IInformacionDetallada
    {
        // Atributos
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<ItemPedido> Items { get; set; }
        public decimal Total => Items.Sum(item => item.Subtotal);

        public Pedido(int IdPedido)
        {
            Id = IdPedido;
            Fecha = DateTime.Now;
            Items = new List<ItemPedido>();
        }
        
        // Metodos
        // Estamos asignando el valor del objeto abstracto  Producto como param
        public void AgregarItem(Producto Producto, int Cantidad)
        {
            if (Producto.Stock >= Cantidad)
            {
                Items.Add(new ItemPedido(Producto, Cantidad));
                Producto.DisminuirStock(Cantidad);
                Console.WriteLine($"El Producto {Producto.Nombre} con cantidad {Cantidad}, se ha agregado al Pedido");
                Console.WriteLine();
            } else
            {
                Console.WriteLine($"No hay suficiente stock de {Producto.Nombre}");
                Console.WriteLine();
            }
        } // Fin de Agregar Item
        
        public void MostrarDetalles()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Detalles del Pedido #{Id}");
            Console.WriteLine($"Fecha: {Fecha:dd/MM/yyyy HH:mm:ss}");

            foreach (var item in Items)
            {
                Console.WriteLine($"Producto: {item.Producto.Nombre}, Cantidad: {item.Cantidad}, Subtotal: {item.Subtotal:C}");
            }
            Console.WriteLine($"Total: {Total:C}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
        } // Fin de MostrarDetalles
        
        public string ObtenerInformacionDetallada()
        {
            return $"Detalles del Pedido #{Id}\n" +
                   $"Fecha: {Fecha:dd/MM/yyyy HH:mm:ss}\n";
        }

    } // Fin de class
}
