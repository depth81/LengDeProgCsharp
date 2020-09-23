using System;

namespace Ejemplo3{

    class Vehiculo{

        /*Propiedades y modificadores de acceso (public, private, internal, protected, etc)
            Public: Se puede acceder a ella desde cualquier clase.
            Private: Se puede acceder a ella solamente dentro de la misma clase.
            Protected: Se puede acceder a ella desde las clases que heredan de la clase padre en
            donde está definida la propiedad.
        */
        public string Marca {get; set;}

        public string Serie {get; set;}

        short modelo;

        public string MarcaSerie{
            get{
                return $"Marca: {Marca} , Serie: {Serie}";
            }
        }

        public short Modelo {

            get {return modelo;}

            set {

                if(value>2017 && value<2022){
                    modelo = value;
                }
                else{
                    System.Console.WriteLine("Modelo incorrecto");
                }

            }

        }

        string placa; //variable local
        public string Placa{
            get {return placa;}
            set 
            {
                if(value.Length==6){
                    placa = value;
                }else{
                    System.Console.WriteLine("Deben ser seis (6) dígitos");
                }
            }
        }

        public string Ruta { get; set; }

        //Métodos
        public void prender(){

            System.Console.WriteLine("Encendiendo...");

        }


    }

}