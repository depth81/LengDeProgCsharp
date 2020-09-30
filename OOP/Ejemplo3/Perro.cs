using System;

namespace Ejemplo3
{

    //Esta es la clase Padre.
    class Perro : AnimalDomestico
    {
        
        //Propiedades o atributos específicos de la clase Perro
        private string tipoEntrenamiento { get; set; }

        //Métodos o funciones
        
        //get()
        public void mostrarTipoEntrenamiento(string tipoEntr){

            tipoEntrenamiento = tipoEntr;
            Console.WriteLine($"El tipo de entrenamiento es: {tipoEntrenamiento}");

        }

        public override string sonido(){

            return "Guau";

        }
        
    }
}

