using System;

namespace ejercicio27_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido al sistema de venta de boletos\n");

                    Console.WriteLine("Lugares de destino:");
                    Console.WriteLine("1. Quito - Precio: $80");
                    Console.WriteLine("2. Galapagos - Precio: $150");
                    Console.WriteLine("3. Esmeraldas - Precio: $40");
                    Console.WriteLine("4. Salir");

                    Console.Write("\nElige una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            CalcularPrecio(80, "Quito");
                            break;
                        case 2:
                            CalcularPrecio(150, "Galapagos");
                            break;
                        case 3:
                            CalcularPrecio(40, "Esmeraldas");
                            break;
                        case 4:
                            Console.WriteLine("Gracias por usar nuestro sistema. ¡Hasta luego!");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Por favor, elige una opción válida.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
            }
        }

        static void CalcularPrecio(double precioBase, string destino)
        {
            Console.WriteLine($"\nHas seleccionado {destino}.");
            Console.Write("Ingrese la cantidad de boletos deseados: ");
            double cantidad = Convert.ToDouble(Console.ReadLine());
            double total = cantidad * precioBase;
            double descuento = total * 0.05;
            double totalPagar = total - descuento;

            Console.WriteLine($"El total a pagar por {cantidad} boleto(s) a {destino} es: ${totalPagar}\n");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
