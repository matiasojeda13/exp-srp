using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = Conversor.ConvertirAPesos(dinero, moneda);
            return pesos >= Alfajor.PrecioTotal(a);
        }
    }
}