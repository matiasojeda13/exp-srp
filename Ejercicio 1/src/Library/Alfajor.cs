using System;

namespace Expert_SRP
{
    public class Alfajor 
    { // la clase alfajor debe ser la experta en calcular el precio total que luego se le paso a la clase kiosco
    // para ver si puede comprar
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}