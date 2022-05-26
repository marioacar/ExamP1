
using ExamP1.Model;
using ExamP1.Repositories;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using System.Text;
using Bogus;

namespace ExamP1.ViewModel
{
    public class DetallesGeneralViewModel : BaseViewModel
    {

        public Movie Movie { get; set; }


        public ICommand cmdGrabaMovie { get; set; }
        //public ICommand cmdGrabaProductora { get; set; }
        public DetallesGeneralViewModel(Movie movie)
        {

            Movie = movie;

            cmdGrabaMovie = new Command<Movie>((item) => cmdGrabaMovieMetodo(item));
            //cmdGrabaProductora = new Command(() => cmdGrabaProductoraMetodo());

        }

        //private void cmdGrabaProductoraMetodo()
        //{
        //    temp productora = new Faker<temp>()
        //       .RuleFor(c => c.Avatar, f => f.Person.Avatar);
            
        //    if(Movie.Productoras == null)
        //    {
        //        Movie.Productoras = new System.Collections.ObjectModel.ObservableCollection<Productora>();
        //    }
        //    Movie.Productoras.Add(new Productora() { Avatar = productora.productora });

        //    OnPropertyChanged();
          
        //}

        //class temp
        //{
        //    public string Avatar { get; set; }
        //}




        private void cmdGrabaMovieMetodo(Movie movie)
        {
            App.MoviesDb.InsertOrUpdate(movie);
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
