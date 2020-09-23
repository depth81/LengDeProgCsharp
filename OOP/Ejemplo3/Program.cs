using System;

namespace Ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            System.Console.WriteLine("***CONCESIONARIO***");

            System.Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();

            System.Console.WriteLine("Serie: ");
            string serie = Console.ReadLine(); 

            System.Console.WriteLine("Modelo: ");
            short modelo = short.Parse(Console.ReadLine());

            System.Console.WriteLine("Placa: ");
            string placa = Console.ReadLine();

            System.Console.WriteLine("Remolque: ");
            string remolque = Console.ReadLine();

         /*    //Instancia con var o el nombre de la clase iniciando
            var vehiculoUno = new Vehiculo(){    

                //A cada propiedad se le asigna el valor de la variable correspondiente.
                Marca = marca,

                Serie = serie,

                Modelo = modelo,

                Placa = placa
            
            };

            Console.WriteLine($"{vehiculoUno.Placa}");
            vehiculoUno.prender();

            System.Console.WriteLine(vehiculoUno.MarcaSerie); */

            //Instanciar un objeto tipo Camion.
            var camionUno = new Camion(){    

                //A cada propiedad se le asigna el valor de la variable correspondiente.
                Marca = marca,

                Serie = serie,

                Modelo = modelo,

                Placa = placa,

                Remolque = remolque
            
            };

            System.Console.WriteLine($"{camionUno.MarcaSerie}, con remolque {camionUno.Remolque}");

            System.Console.WriteLine(camionUno.Remolque);

            camionUno.listarRuta();


        }
    }
}