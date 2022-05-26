using ExamP1.Repositories;
using ExamP1.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamP1
{
    public partial class App : Application
    {
        #region Repositories
        //private static ActorRepository _ActorDb;
        //public static ActorRepository ActorDb
        //{
        //    get
        //    {
        //        if (_ActorDb == null)
        //        {
        //            _ActorDb = new ActorRepository();
        //        }
        //        return _ActorDb;
        //    }
        //}



        //DB de peliculas

        private static MovieRepository _MovieDb;
        public static MovieRepository   MoviesDb
        {
            get
            {
                if (_MovieDb == null)
                {
                    _MovieDb = new MovieRepository();
                }
                return _MovieDb;

            }
        }

        //DB de Productora

        private static ProductoraRepository _ProductorasDb;
        public static ProductoraRepository ProductorasDb
        {
            get
            {
                if (_ProductorasDb == null)
                {
                    _ProductorasDb = new ProductoraRepository();
                }
                return _ProductorasDb;

            }
        }




        #endregion

        
        public App()
        {
            InitializeComponent();
            MoviesDb.Init();
            ProductorasDb.Init();
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
