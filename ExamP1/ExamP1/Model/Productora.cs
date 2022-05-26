﻿using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamP1.Model
{
    [Table("Productoras")]
    public class Productora
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Portada { get; set; }
        public string Name { get; set; }


        [ForeignKey(typeof(Movie))]
        public int FKMovie { get; set; }

    }
}
