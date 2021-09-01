using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }  
        public string SectorBiblioteca { get ; set; } // La clase Libro solo debería poseer las características del mismo
        public string EstanteBiblioteca { get ; set; } // Se deberá crear una nueva clase para la parte de biblioteca, que guarde los datos de los libros y otra para ubicación de estos
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
