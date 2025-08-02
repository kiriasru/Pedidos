
namespace Pedidos
{
    public class ItemPedido
    {
        // Puedo declarar objetos de clases abstractas siempre y cuando no las inicialice
        // Es decir Producto = new Producto();
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal => Producto.Precio * Cantidad;
        
        // Estamos asignando el valor del objeto del parametro Producto a la propiedad Producto
        public ItemPedido(Producto Producto, int Cantidad) 
        {
            this.Producto = Producto;
            this.Cantidad = Cantidad;
        } // Fin de ItemPedido
        
    } // Fin de class
    
} // Fin de namespace
