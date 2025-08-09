﻿namespace Pedidos.Herencia
{
    public class Libro : Producto, IInformacionDetallada
    {
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public override void MostrarInformacion()
        {
            Console.WriteLine();
            Console.WriteLine("***** DATOS DEL PRODUCTO *****");
            Console.WriteLine(ObtenerInformacionDetallada());
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
        }

        public override void MostrarInformacion(string Direccion)
        {
            Console.WriteLine();
            Console.WriteLine("***** DATOS DEL PRODUCTO *****");
            Console.WriteLine(ObtenerInformacionDetallada());
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
        }

        public override void MostrarInformacion(string Direccion, string Dni)
        {
            Console.WriteLine();
            Console.WriteLine("***** DATOS DEL PRODUCTO *****");
            Console.WriteLine(ObtenerInformacionDetallada());
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Dni: {Dni}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
        }
    }
}