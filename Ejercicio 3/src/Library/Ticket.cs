using System;
using System.Text;
using System.Linq;

namespace Library
{
    public class PrintTicket
    {
        public static void Print(Consulta consulta)
        {
                Console.WriteLine($@"Se realizo la consulta con exito.
                Numero de consulta: {consulta.Contador}
                Fecha de consulta: {consulta.Fecha}
                Lugar de consulta: {consulta.Lugar}
                Nombre paciente: {consulta.Paciente.Nombre}
                Identificacion de cliente: {consulta.Paciente.Id}
                Telefono/Celular paciente: {consulta.Paciente.Telefono}
                Doctor asignado: {consulta.Doctor.Nombre}
                Especialiad de doctor: {consulta.Doctor.Especialidad}");
        }
    }
}