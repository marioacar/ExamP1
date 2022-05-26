using ExamP1.View;
using ExamP1.Model;
using ExamP1.Repositories;
using Bogus;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamP1.ViewModel
{
    public class InicioViewModel : BaseViewModel
    {
        public ObservableCollection<Movie> Movies { get; set; }

        public ICommand cmdAgregarMovie { get; set; }
        public ICommand cmdModificarMovie { get; set; }

        public ICommand cmdAgregarProductora { get; set; }

        public InicioViewModel()
        {
            Movies = new ObservableCollection<Movie>();
            cmdAgregarMovie = new Command(() => cmdAgregarMovieMetodo());
            //cmdAgregarProductora = new Command(() => cmdAgregarProductoraMetodo);
            cmdModificarMovie = new Command<Movie>((item) => cmdModificarMovieMetodo(item));

        }



        //private void cmdAgregarProductoraMetodo(Productora productora)
        //{
        //    Productora productora = new Faker<Productora>()
        //        .RuleFor(c => c.Avatar, f => f.Person.Avatar);


        //    App.Current.MainPage.Navigation.PushAsync(new DetallesGeneral(productora));
        //}


        private void cmdAgregarMovieMetodo(Movie movie)
        {
            App.Current.MainPage.Navigation.PushAsync(new DetallesGeneral(movie));
        }
        private void cmdModificarMovieMetodo(Movie movie)
        {
            App.Current.MainPage.Navigation.PushAsync(new DetallesGeneral(movie));
        }

        private void cmdAgregarMovieMetodo()
        {
            Movie movie = new Faker<Movie>()
                 .RuleFor(c => c.Avatar, f => f.Person.Avatar);
           
               
            App.Current.MainPage.Navigation.PushAsync(new DetallesGeneral(movie));
        }





        public void GetAll()

        {
            if (Movies != null)
            {
                Movies.Clear();
                App.MoviesDb.GetAll().ForEach(item => Movies.Add(item));
            }
            else
            {
                Movies = new ObservableCollection<Movie>(App.MoviesDb.GetAll());

            }
            OnPropertyChanged();
        }


    }
}
