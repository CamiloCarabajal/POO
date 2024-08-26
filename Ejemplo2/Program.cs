using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
     class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 regitros de productos, cada producto tiene:
            //-Codigo Articulo (3 digitos no correlativos)
            //-Precio
            //-Codigo de marca
            //Segundo lote con las ventas de la semana. Cada venta tiene:
            //-Codigo articulo
            //-Cantidad
            //-Codigo Cliente
            //Este lote corta con codigo de Cliente cero

            Articulo[] articulos = new Articulo[10];
            for (int i = 0; i < articulos.Length; i++) 
            {
                Console.WriteLine("Ingrteese los datos del producto..");
                Console.WriteLine("Codigo:");
                articulos[i].CodArticulo= int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[i].Precio= float.Parse(Console.ReadLine());
                Console.WriteLine("Marca:");
                articulos[i].CodigoMarca= int.Parse(Console.ReadLine());
            }
            //Cargado el vector completo con los 10
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta:");
            Console.WriteLine("Codigo Cliente:");
            venta.CodigoCliente= int.Parse(Console.ReadLine());

            while (venta.CodigoCliente!=0) 
            {
                Console.WriteLine("Codigo Articulo:");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                venta.Cantidad= int.Parse(Console.ReadLine());
                //Trabajamos
                //Pido Cliente nuevamente
                Console.WriteLine("Ingrese la venta:");
                Console.WriteLine("Codigo Cliente:");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }

        }
    }
}
