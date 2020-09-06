using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private string nombre;
        
        private string especialidad;

        public string Nombre 
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if(isValidNombre(value))
                {
                    this.nombre = value;
                }
            }
        }
        public string Especialidad
        {
            get
            {
                return this.especialidad;
            }
            set
            {
                if(isValidEspecialidad(value))
                {
                    this.especialidad = value;
                }
            }
        }
        public Doctor(string nombre, string especialidad)
        {
            this.Nombre = nombre;
            this.Especialidad = especialidad;
        }

        public static bool isValidNombre(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return false;
            }
            return true;
        }
        
        public static bool isValidEspecialidad(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return false;
            }
            return true;
        } 
    }
}