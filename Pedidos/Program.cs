using Pedidos;
// Objetos
Producto producto = new Producto();
producto.Id = 1;
producto.Nombre = "Laptop";
producto.Precio = 5000;
producto.Stock = 10;

Producto producto1 = new Producto();
producto1.Id = 2;
producto1.Nombre = "Mouse";
producto1.Precio = 250;
producto1.Stock = 15;

// Mostrar productos
producto.MostrarInformacion();
producto1.MostrarInformacion();

// Reducir del stock y mostrar
producto.DisminuirStock(1);
producto.MostrarInformacion();

producto1.DisminuirStock(4);
producto1.MostrarInformacion();