using System;

namespace SRP
{
    public class Biblioteca
    {
        public static void AlmacenarLibro(Libro l, String sector, String estante)
        {
            l.SectorBiblioteca = sector;
            l.EstanteBiblioteca = estante;
        }
    }
} 
