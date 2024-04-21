//Un vendedor desea calcular la comisión total sobre la venta de varios artículos. Al
//vendedor le corresponde el 10% de comisión sobre artículos, cuyo precio es menor o
//igual a $1.000 y el 7% de comisión sobre aquellos artículos cuyo precio sea mayor de
//$1.000. Elabore un algoritmo para obtener la comisión total, si se conoce que el
//vendedor hizo N ventas.

using System;

class Program
{
    static void Main()
    {
        Ventas(); //llamamos a la funcion que iniciara el programa 
    }

    static void Ventas()
    {
        double acumuladorComisiones = 0;
        int ventasRealizadas = 0;

        while (true)
        {
            double articulo = Menu();

            if (articulo == 4)
            {
                Console.WriteLine("Ha elegido salir del programa.");
                break;
            }

            double comision = VentasArt(articulo);
            acumuladorComisiones += comision; // Acumular las comisiones
            ventasRealizadas++;

            Console.WriteLine("La comisión de esta venta es: " + comision);
        }

        // Mostrar al final del programa las ventas que se realizaron y las comisiones totales del asesor
        Console.WriteLine($"Total de ventas realizadas: {ventasRealizadas}");
        Console.WriteLine("Las comisiones totales del asesor son: " + acumuladorComisiones);
    }

    static double Menu() //creamos un menu para hacerel programa mas intuitivo
    {
        Console.WriteLine("Hola Bienvenido a su tienda de confianza");
        Console.WriteLine("Este es el Menu de nuestros productos");
        Console.WriteLine("Seleccione la opción que desea comprar o saber su precio");
        Console.WriteLine("------------------Menu----------------");
        Console.WriteLine("1. Camisetas");
        Console.WriteLine("2. Chaquetas");
        Console.WriteLine("3. Medias");
        Console.WriteLine("4. Salir");
        double articulo = double.Parse(Console.ReadLine());
        return articulo;
    }

    static double VentasArt(double articulo)
    {
        double precio = 0;
        double comision = 0;
        double compra = 0;
        double venta = 0;

        if (articulo == 1)
        {
            precio = 3000;
            Console.WriteLine("Ha seleccionado Camiseta, su precio es: " + precio);
            Console.WriteLine("Cuantas unidades desea comprar?");
            compra = double.Parse(Console.ReadLine());
            comision = precio * compra * 0.07;
            venta = precio * compra;
        }
        else if (articulo == 2)
        {
            precio = 5000;
            Console.WriteLine("Ha seleccionado Chaqueta, su precio es: " + precio);
            Console.WriteLine("Cuantas unidades desea comprar?");
            compra = double.Parse(Console.ReadLine());
            comision = precio * compra * 0.07;
            venta = precio * compra;
        }
        else if (articulo == 3)
        {
            precio = 200;
            Console.WriteLine("Has seleccionado Medias, su precio es: " + precio);
            Console.WriteLine("Cuantas unidades desea comprar?");
            compra = double.Parse(Console.ReadLine());
            comision = precio * compra * 0.01;
            venta = precio * compra;
        }

        Console.WriteLine("El valor a pagar es: " + venta);
        return comision;
    }
}
