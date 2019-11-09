using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarlaFernandez3A.Clases;

namespace KarlaFernandez3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Ingrese apellidos: ");
            string ape = Console.ReadLine();
            cliente.Apellidos = ape;

            Console.WriteLine("Ingrese nombres: ");
            string nom = Console.ReadLine();
            cliente.Nombres = nom;

            Console.WriteLine("Ingrese número de cédula de identidad: ");
            string linea = Console.ReadLine();
            int ced = int.Parse(linea);
            cliente.NumeroDeCedulaDeIdentidad = ced;

            Console.WriteLine("Ingrese dirección: ");
            string dir = Console.ReadLine();
            cliente.Direccion = dir;

            Gasolina gasolina = new Gasolina();
            
            Console.WriteLine("Ingrese el tipo de gasolina que desee: 'Extra' o 'Super' ");
            String tip = Console.ReadLine();
            gasolina.Tipo = tip;

            Console.WriteLine("Ingrese la cantidad de galones que desee: ");
            int cant = int.Parse(Console.ReadLine());
            gasolina.CantidadDeGalones = cant;

            Console.WriteLine("\n");
            Console.WriteLine("Cliente: " + cliente.Apellidos + " " + cliente.Nombres);
            Console.WriteLine("Número de Cédula de identidad: " + cliente.NumeroDeCedulaDeIdentidad);
            Console.WriteLine("Dirección: " + cliente.Direccion);
            Console.WriteLine("Tipo de gasolina: " + gasolina.Tipo);
            Console.WriteLine("Cantidad de galones: " + gasolina.CantidadDeGalones);
            Console.WriteLine("Precio: " + gasolina.PrecioDeVenta);
            Console.WriteLine("Subtotal: " + gasolina.Subtotal);
            Console.WriteLine("Iva: " + gasolina.Iva);
            Console.WriteLine("Total a cancelar: " + gasolina.Total);

            Console.ReadLine();
        }
    }
}
