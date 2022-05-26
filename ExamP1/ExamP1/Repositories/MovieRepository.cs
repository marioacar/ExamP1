using ExamP1.Model;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;



namespace ExamP1.Repositories
{
    public class MovieRepository
    {
        SQLiteConnection connection;
        public MovieRepository()
        {
            connection = new SQLiteConnection(Constants.Constants.DatabasePath, Constants.Constants.Flags);
            connection.CreateTable<Movie>();
        }

        public void Init()
        {
            connection.CreateTable<Movie>();
        }
        public void InsertOrUpdate(Movie Movie)
        {
            if (Movie.Id == 0)
            {
                Debug.WriteLine($"Id antes de registrar {Movie.Id}");
                connection.InsertWithChildren(Movie);
                Debug.WriteLine($"Id despues de registrar {Movie.Id}");
            }
            else
            {
                Debug.WriteLine($"Id antes de actualizar {Movie.Id}");
                connection.Update(Movie);
                App.ProductorasDb.InsertOrUpdate(Movie.Productora);
                Debug.WriteLine($"Id despues de actualizar {Movie.Id}");
            }
        }

        public Movie GetById(int Id)
        {
            return connection.Table<Movie>().FirstOrDefault(item => item.Id == Id);
            //return connection.GetAllWithChildren<Contacto>(item => item.Id == Id).FirstOrDefault();



        }

        public List<Movie> GetAll()
        {

            return connection.GetAllWithChildren<Movie>().ToList();
        }


        public void DeleteItem(int Id)
        {
            Movie contacto = GetById(Id);
            connection.Delete(contacto);
        }
    }
}
