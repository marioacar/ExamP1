using ExamP1.Model;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ExamP1.Repositories
{
    public  class ProductoraRepository
    {
        SQLiteConnection connection;

        public ProductoraRepository()
        {
            connection = new SQLiteConnection(Constants.Constants.DatabasePath, Constants.Constants.Flags);
            connection.CreateTable<Productora>();
        }


        public void Init()
        {
            connection.CreateTable<Productora>();
        }
        public void InsertOrUpdate(Productora acta)
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

        public Productora GetById(int Id)
        {
            return connection.Table<Productora>().FirstOrDefault(item => item.Id == Id);
            //return connection.GetAllWithChildren<Contacto>(item => item.Id == Id).FirstOrDefault();



        }

        //internal void InsertOrUpdate(ObservableCollection<Productora> productora)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Productora> GetAll()
        {

            return connection.Table<Productora>().ToList();
        }


        public void DeleteItem(int Id)
        {
            Productora acta = GetById(Id);
            connection.Delete(acta);
        }

    }
}

