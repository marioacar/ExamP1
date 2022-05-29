using ExamP1.Model;
using SQLite;
using System;
using System.Collections.Generic;
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

            AgregarDesdeInicio("a");
            AgregarDesdeInicio("b");
            AgregarDesdeInicio("c");
            AgregarDesdeInicio("d");
            AgregarDesdeInicio("e");
        }



        private void AgregarDesdeInicio(string Name)
        {
            Actor actor = GetByNombre(Name);

            if (actor == null)
            {
                InsertOrUpdate(new Actor() { Name = Name });
            }
        }

        public void InsertOrUpdate(Actor acta)
        {
            if (acta.Id == 0)
            {

                connection.Insert(acta);

            }
            else
            {

                connection.Update(acta);

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
