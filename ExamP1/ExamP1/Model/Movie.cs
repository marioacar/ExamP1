using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExamP1.Model
{
    [Table("MoviesAll")]
    public class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string titulo { get; set; }
        public string sinopsis { get; set; }

        //public string productora { get; set; }
        //public string actores { get; set; }

        [ForeignKey(typeof(Productora))]
        public int FKProductora { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public ObservableCollection<Productora> Productora { get; set; }

    }
}
