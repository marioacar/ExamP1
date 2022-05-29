using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExamP1.Model
{

    [Table("Actors")]
    public class Actor
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        
        [ManyToMany(typeof(MovieActor),CascadeOperations = CascadeOperation.All)]
        public ObservableCollection<Movie> Movies { get; set; }
        
    }
}
