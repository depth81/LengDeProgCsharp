using System;

namespace Ejemplo3{
    class Camion: Vehiculo{

        //Camion hereda de Vehiculo todos los métodos y propiedades.
        //Las siguientes son propiedades específicas de Camion.

        public string Remolque { 
            get{
                {return Remolque;}
            }
            set{
                /***SWITCH CASE***/
                switch(value.ToUpper()){
                    case "CAMABAJA":
                        Remolque = value;
                        break;
                    case "ESTACAS":
                        Remolque = value;
                        break;
                    case "PLANCHON":
                        Remolque = value;
                        break;
                    case "CISTERNA":
                        Remolque = value;
                        break;
                    default:
                        System.Console.WriteLine("Remolque no existe");
                        break;
                }

            }
        }

        public void mostrarDatos(){
            /*Serie es protected en Vehiculo y la puedo ver desde acá, en cambio,
            Marca es private en Vehiculo y no la puedo ver desde acá.*/

            System.Console.WriteLine(Serie); 
        }

        public String listarRuta(){
            return Ruta.ToString();
        }

    }

}