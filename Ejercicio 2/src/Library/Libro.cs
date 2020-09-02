using System;

namespace SRP
{
    public class Libro
    {
        /*no se cumple con srp debido a que se le asigna la responsabilidad de almacenarse a la clase libro, la cual no deberia 
        preocuparse de ello, y si deberia hacerlo una clase aparte llamada biblioteca
        ademas no se cumple con el patron expert dado que se le asignan los datos de almacenaje a una clase que no debiera ser
        experta en ello */
        
        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
