using System;
using System.Text;

namespace Library
{   /* con respecto a srp y expert, no cumple con srp dado que en caso de que se quieran cambiar datos del paciente o del doctor,
        se tendria que cambiar la clase de la consulta en si misma. Por ello convendria crear una clase para los datos del paciente
        y otra clase para los datos del doctor para luego volcar los datos de esas dos clases en la clase consulta. */
    public class Consulta
    {
        private string lugar;
        private DateTime fecha;
        public string  Lugar
        {
            get
            {
                return this.lugar;
            }
            set
            {
                if (IsValidLugar(value))
                {
                    this.lugar = value;
                }
            }
        }
        public static bool IsValidLugar(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return false;
            }
            return true;
        }
        private static int contador = 0;
        public int Contador{get;set;} 
        public DateTime Fecha {get;set;}
        public Doctor Doctor {get;set;}
        public Paciente Paciente {get;set;}
        public Consulta(DateTime fecha, string lugar, Doctor doctor, Paciente paciente)
        {
            this.Fecha = fecha;
            this.Lugar = lugar;
            this.Doctor = doctor;
            this.Paciente = paciente;
            this.Contador = contador;
            contador++;
        }
    }
}
