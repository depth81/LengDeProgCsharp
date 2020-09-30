using System;

namespace Ejemplo3
{

    //Esta es la clase Padre.
    abstract class AnimalDomestico
    {
      //Propiedades o atributos
        public string TipoAnimal { get; set;}
        public string Raza { get; set; }
        public int Edad { get; set; }
        
        //Métodos o funciones
        public void comer(){

            Console.WriteLine("Comiendo mmmm...");

        }

        /*   public string dimeRaza(){

                return Raza;

            }

            public string dimeTipoAnimal(){

                return TipoAnimal;

            } */

        /***MÉTODO ABSTRACTO***/
        //Solo se le define su estructura. La clase que lo contiene debe ser abstracta.
        //Debe ser implementado en las clases hijas 'Perro' y 'Gato' con override
        public abstract string sonido();
    }
}

