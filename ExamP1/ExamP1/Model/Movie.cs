using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamP1.Model
{
    [Table("MoviesAll")]
    public class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string portada { get; set; }
        public string titulo { get; set; }
        public string sinopsis { get; set; }
        public DateTime Publicacion { get; set; }

    }
}
