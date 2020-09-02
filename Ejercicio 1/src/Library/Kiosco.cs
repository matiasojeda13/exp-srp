using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa; // la funcion de imbocar el total del precio del alfajor debe ser responsabilidad
            // de la clase alfajor
        }
        // no cumple con srp porque tiene mas de una responsabilidad al verificar si puede comprar y convertir a pesos
        // la responsabilidad de convertir a pesos debe ser de una clase distinta a la de kiosco
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}