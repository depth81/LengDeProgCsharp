using System;

namespace Ejemplo3
{

    //Esta es la clase Padre.
    class Gato : AnimalDomestico
    {
        
        //Propiedades o atributos específicos de la clase Perro
        private string Reflejo { get; set; }

        //Métodos o funciones
        /* public void mostrarReflejo(){

            Console.WriteLine(Reflejo);

        } */
        
        public override string sonido(){

            return "Miauu";

        }
        
    }
}

