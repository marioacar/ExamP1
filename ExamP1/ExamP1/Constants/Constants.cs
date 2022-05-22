using System;
using System.Collections.Generic;
using System.Text;

namespace ExamP1.Constants
{
    public class Constants
    {
        public const string DatabaseFilename = "dbContactos.db3";

        public const SQLite.SQLiteOpenFlags flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;
    }
}
