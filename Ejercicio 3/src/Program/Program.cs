using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Alberto Rodriguez","Oncologia");
            Doctor doctor2 = new Doctor("","Oncologia");
            Paciente paciente1 = new Paciente("Matias Ojeda","4.548.797-8","099636261");
            Paciente paciente2 = new Paciente("juan","45632","");
            Consulta consulta1 = new Consulta(DateTime.Now,"Consultorio Parque Batlle",doctor1,paciente1);
            PrintTicket.Print(consulta1);
        }
            
    }
}
