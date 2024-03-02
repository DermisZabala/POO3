using System;
using System.Reflection.PortableExecutable;

namespace POO_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creacion de instancias de la clase coche
            Coche coche1 = new Coche();
            Coche coche2 = new Coche(460, 190);
            Coche coche3 = new Coche(400, 170, 0);

            //Imprimir informacion de cada coche
            Console.WriteLine("Coche 1\n" + coche1.getInfoCoche());
            Console.WriteLine("Coche 2\n" + coche2.getInfoCoche());
            Console.WriteLine("Coche 3\n" + coche3.getInfoCoche());
        }
    }

    class Coche
    {
        //Atributos de la clase coche
        private int ruedas;
        private double largo;
        private double ancho;

        //Constructor predeterminado
        public Coche()
        {
            ruedas = 4;
            largo = 420;
            ancho = 180;

        }

        //Constructor de dos parámetros
        public Coche(double largoCoche2, double anchoCoche2)
        {
            ruedas = 4;
            largo = largoCoche2;
            ancho = anchoCoche2;
        }

        //Constructor con tres parámetros 
        public Coche(double largoCoche3, double anchoCoche3, int nulo = 0)
        {
            ruedas = 4;
            largo = largoCoche3;
            ancho = anchoCoche3;
        }

        //Método para devolver información del coche
        public String getInfoCoche()
        {
            
           return "Estado inicial coche \nRuedas: " + ruedas + " Largo: " + largo + "cm Ancho: " + ancho + "cm";
            
        }

    }
}
