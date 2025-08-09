﻿using Pedidos;
using Pedidos.Herencia;

Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "iPhone 17 Pro Max";
electronico.Precio = 1000;
electronico.Stock = 200;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110V";
electronico.MostrarInformacion("San Pedro Sula");

Libro libro = new Libro();
libro.Id = 4;
libro.Nombre = "El Señor de los Anillos";
libro.Precio = 250;
libro.Stock = 1500;
libro.ISBN = "9788845292613";
libro.Autor = "J.R.R. Tolkien";
libro.NumeroPaginas = 500;
libro.MostrarInformacion();

Libro libro1 = new Libro();
libro1.Id = 5;
libro1.Nombre = "Luna de Plutón";
libro1.Precio = 250;
libro1.Stock = 1600;
libro1.ISBN = "6070731743";
libro1.Autor = "Dross";
libro1.NumeroPaginas = 471;
libro1.MostrarInformacion("Puerto Cortés", "05011979000123");

Producto mouse = new Electronico(4, "Mouse inalámbrico", 250);
mouse.MostrarInformacion();

Pedido pedido = new Pedido(1);
pedido.AgregarItem(electronico, 1);
pedido.AgregarItem(electronico, 5);
pedido.MostrarDetalles();

Pedido pedido1 = new Pedido(2);
pedido1.AgregarItem(libro, 10);
pedido1.AgregarItem(libro, 51);
pedido1.MostrarDetalles();

Pedido pedido2 = new Pedido(3);
pedido2.AgregarItem(libro1, 15);
pedido2.AgregarItem(libro1, 25);
pedido2.MostrarDetalles();

Pedido pedido3 = new Pedido(4);
pedido3.AgregarItem(mouse, 15);
pedido3.MostrarDetalles();

List<Producto> lista = new List<Producto>();
lista.Add(electronico);
lista.Add(libro);
lista.Add(libro1);
lista.Add(mouse);

foreach (Producto producto in lista)
{
    producto.MostrarInformacion();
}