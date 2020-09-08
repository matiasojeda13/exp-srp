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
            Doctor doctor3 = new Doctor("Jorge","Medicina General");
            Paciente paciente3 = new Paciente("Pedro","4.321.256-9","096325148");
            Paciente paciente1 = new Paciente("Matias Ojeda","4.548.797-8","099636261");
            Paciente paciente2 = new Paciente("juan","45632","");
            Consulta consulta1 = new Consulta(DateTime.Now,"Consultorio Parque Batlle",doctor1,paciente1);
            Consulta consulta2 = new Consulta(DateTime.Now,"Consultorio Tres Cruces",doctor2,paciente2);
            Consulta consulta3 = new Consulta(DateTime.Now,"Consultorio Tres Cruces",doctor3,paciente3);

            PrintTicket.Print(consulta1);
            Console.WriteLine();
            PrintTicket.Print(consulta2);
            PrintTicket.Print(consulta3);
        }
            
    }
}
