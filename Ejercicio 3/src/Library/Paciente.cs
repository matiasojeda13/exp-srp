using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        private string nombre;
        private string id;
        private string telefono;

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
                else{
                    this.nombre = "incorrecto";
                }
            }
        }

        public string Id
        {
            get{
                return this.id;
            }
            set
            {
                if(isValidId(value))
                {
                    this.id = value;
                }
                else{
                    this.id = "incorrecto";
                }
            }
        }
        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                if(isValidTelefono(value))
                {
                    this.telefono = value;
                }
                else{
                    this.telefono = "incorrecto";
                }
            }
        }

        public Paciente(string nombre, string id, string telefono)
        {
            this.Nombre = nombre;
            this.Id = id;
            this.Telefono = telefono;

        }

        private bool isValidNombre(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return false;
            }
            return true;
        }
        
        public static bool isValidTelefono(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return false;
            }
            return true;
        }

        public static bool isValidId(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return false;
            }
            return true;
        }
        
    }
}