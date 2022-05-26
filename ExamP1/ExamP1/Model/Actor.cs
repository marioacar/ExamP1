using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamP1.Model
{

    [Table("Actores")]
    public class Actor
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Alias { get; set; }

        [ForeignKey(typeof(Movie))]

        public int FKMovie { get; set; }
    }
}
