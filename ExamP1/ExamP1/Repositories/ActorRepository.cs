using ExamP1.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExamP1.Repositories
{
    public class ActorRepository
    {
        SQLiteConnection connection;

        public ActorRepository()
        {
            connection = new SQLiteConnection(Constants.Constants.DatabasePath, Constants.Constants.Flags);
            connection.CreateTable<Actor>();


            

        }


        public void Init()
        {
            connection.CreateTable<Actor>();

            AgregarDesdeInicio("Mario", "carvantes");
            AgregarDesdeInicio("AXL", "Bell");
            AgregarDesdeInicio("Sewer", "Jvnko");
            AgregarDesdeInicio("Wiz", "wiz");
            AgregarDesdeInicio("Walter", "white");
            AgregarDesdeInicio("Francisco", "Rojas");
        }



        private void AgregarDesdeInicio(string name, string alias)
        {
            Actor actor = GetByNombre(name);

            if (actor == null)
            {
                InsertOrUpdate(new Actor() { Name = name, Alias = alias });
            }
        }

        public void InsertOrUpdate(Actor acta)
        {
            if (acta.Id == 0)
            {
                Debug.WriteLine($"Id antes de registrar {acta.Id}");
                connection.Insert(acta);
                Debug.WriteLine($"Id despues de registrar {acta.Id}");
            }
            else
            {
                Debug.WriteLine($"Id antes de actualizar {acta.Id}");
                connection.Update(acta);
                Debug.WriteLine($"Id despues de actualizar {acta.Id}");
            }
        }

        public Actor GetById(int Id)
        {
            return connection.Table<Actor>().FirstOrDefault(item => item.Id == Id);
            //return connection.GetAllWithChildren<Contacto>(item => item.Id == Id).FirstOrDefault();



        }

        //internal void InsertOrUpdate(ObservableCollection<Productora> productora)
        //{
        //    throw new NotImplementedException();
        //}


        public Actor GetByNombre(String Name)
        {
            return connection.Table<Actor>().FirstOrDefault(item => item.Name == Name);
        }


        public List<Actor> GetAll()
        {

            return connection.Table<Actor>().ToList();
        }


        public void DeleteItem(int Id)
        {
            Actor acta = GetById(Id);
            connection.Delete(acta);
        }
    }
}
