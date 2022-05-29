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
        private static ActorRepository _ActorDb;
        public static ActorRepository ActorsDb
        {
            get
            {
                if (_ActorDb == null)
                {
                    _ActorDb = new ActorRepository();
                }
                return _ActorDb;
            }
        }



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

        private static ProductoraRepository _ProductoraDb;
        public static ProductoraRepository ProductorasDb
        {
            get
            {
                if (_ProductoraDb == null)
                {
                    _ProductoraDb = new ProductoraRepository();
                }
                return _ProductoraDb;

            }
        }

        //DB de Productora

        private static MoviesActorsRepository _MoviesActorDb;
        public static MoviesActorsRepository MoviesActorsDb
        {
            get
            {
                if (_MoviesActorDb == null)
                {
                    _MoviesActorDb = new MoviesActorsRepository();
                }
                return _MoviesActorDb;

            }
        }




        #endregion


        public App()
        {
            InitializeComponent();
            MoviesDb.Init();
            ProductorasDb.Init();
            ActorsDb.Init();
            MoviesActorsDb.Init();

            MainPage = new NavigationPage(new Inicio());
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
