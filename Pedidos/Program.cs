
using Pedidos;
using Pedidos.Herencia;

// Creando objeto electronico
Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "Iphone 17 Pro Max";
electronico.Precio = 1000;
electronico.Stock = 200;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110V";

electronico.MostrarInformacion();

// Usando metodos de producto (heredados)
Pedido pedido = new Pedido(1);
pedido.AgregarItem(electronico, 1);
pedido.AgregarItem(electronico, 5);
pedido.MostrarDetalles();

electronico.MostrarInformacion();
electronico.MostrarInformacion();

// Crear libro
Libro libro = new Libro();
libro.Id = 4;
libro.Nombre = "El Señor de los Anillos";
libro.Precio = 250;
libro.Stock = 1500;
libro.ISBN = "978884529613";
libro.Autor = "J.R.R. Tolkien";
libro.NumeroPaginas = 500;

libro.MostrarInformacion();

Pedido pedido1 = new Pedido(2);
pedido1.AgregarItem(libro, 10);
pedido1.AgregarItem(libro, 22);
pedido1.MostrarDetalles();

libro.MostrarInformacion();
libro.MostrarInformacion();

// Crear libro 1
Libro libro1 = new Libro();
libro1.Id = 5;
libro1.Nombre = "Luna de Plutón";
libro1.Precio = 250;
libro1.Stock = 1600;
libro1.ISBN = "6070731743";
libro1.Autor = "Dross";
libro1.NumeroPaginas = 471;

libro1.MostrarInformacion();

Pedido pedido2 = new Pedido(3);
pedido2.AgregarItem(libro1, 15);
pedido2.AgregarItem(libro1, 25);
pedido2.MostrarDetalles();

libro1.MostrarInformacion();
libro1.MostrarInformacion();