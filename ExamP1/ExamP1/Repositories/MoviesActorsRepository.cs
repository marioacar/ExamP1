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
    public class MoviesActorsRepository
    {

        SQLiteConnection connection;
        public MoviesActorsRepository()
        {
            connection = new SQLiteConnection(Constants.Constants.DatabasePath, Constants.Constants.Flags);
            connection.CreateTable<MovieActor>();
        }

        public void Init()
        {
            connection.CreateTable<MovieActor>();
        }
        public void InsertOrUpdate(MovieActor MoviesActors)
        {
            if (MoviesActors.Id == 0)
            {
                Debug.WriteLine($"Id antes de registrar {MoviesActors.Id}");
                connection.InsertWithChildren(MoviesActors);
                Debug.WriteLine($"Id despues de registrar {MoviesActors.Id}");
            }
            else
            {
                Debug.WriteLine($"Id antes de actualizar {MoviesActors.Id}");
                //connection.Update(MoviesActors);
                //App.ProductorasDb.InsertOrUpdate(Movie.Productora);
                //Debug.WriteLine($"Id despues de actualizar {Movie.Id}");
            }
        }

        public MovieActor GetById(int Id)
        {
            return connection.Table<MovieActor>().FirstOrDefault(item => item.Id == Id);
            //return connection.GetAllWithChildren<Contacto>(item => item.Id == Id).FirstOrDefault();



        }

        public List<MovieActor> GetAll()
        {

            return connection.GetAllWithChildren<MovieActor>().ToList();
        }


        //public void DeleteItem(int Id)
        //{
        //    Movie contacto = GetById(Id);
        //    connection.Delete(contacto);
        //}
    }
}
