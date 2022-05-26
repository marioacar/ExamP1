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
        public void InsertOrUpdate(Productora productora)
        {
            if (productora.Id == 0)
            {

                connection.Insert(productora);

            }
            else
            {

                connection.Update(productora);

            }
        }

        public Productora GetById(int Id)
        {
            return connection.Table<Productora>().FirstOrDefault(item => item.Id == Id);
            //return connection.GetAllWithChildren<Contacto>(item => item.Id == Id).FirstOrDefault();



        }

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

