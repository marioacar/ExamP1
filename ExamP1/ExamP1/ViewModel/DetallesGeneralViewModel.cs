
using ExamP1.Model;
using ExamP1.Repositories;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using System.Text;


namespace ExamP1.ViewModel
{
    public class DetallesGeneralViewModel
    {

        public Movie Movie { get; set; }


        public ICommand cmdGrabaMovie { get; set; }
        public DetallesGeneralViewModel(Movie movie)
        {

            Movie = movie;

            cmdGrabaMovie = new Command<Movie>((item) => cmdGrabaMovieMetodo(item));


        }

        private void cmdGrabaMovieMetodo(Movie movie)
        {
            App.MoviesDb.InsertOrUpdate(movie);
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
