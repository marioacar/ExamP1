
using ExamP1.Model;
using ExamP1.Repositories;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using System.Text;
using Bogus;
using System.Collections.ObjectModel;

namespace ExamP1.ViewModel
{
    public class DetallesActorViewModel : BaseViewModel
    {

        public Movie Movie { get; set; }


        public ObservableCollection<Actor> Actors { get; set; }


        public ICommand cmdAgregaActor { get; set; }
        public ICommand cmdGrabaMovieActor { get; set; }


        public DetallesActorViewModel(Movie movie)
        {

            Movie = movie;

            Actors = new ObservableCollection<Actor>(App.ActorsDb.GetAll());


            if (Movie.Actors == null)
            {
                Movie.Actors = new ObservableCollection<Actor>();
            }

            cmdAgregaActor = new Command(() => cmdAgregaActorMetodo());
            cmdGrabaMovieActor = new Command<Movie>((item) => cmdGrabaMovieActorMetodo(item));

        }

        private void cmdGrabaMovieActorMetodo(Movie movie)
        {
            App.MoviesDb.InsertOrUpdate(movie);
            App.Current.MainPage.Navigation.PopAsync();
        }

        private void cmdAgregaActorMetodo()
        {
            if(Movie.Actors == null)
            {
                Movie.Actors = new ObservableCollection<Actor>();
            }

            Movie.Actors.Add(new Actor() { Name = Actors[Aleatorio()].Name});
            OnPropertyChanged();
        }

        private int Aleatorio()
        {
            int AllActors = Actors.Count - 1;

            Random rnd = new Random();
            int index = rnd.Next(0, 32000) % AllActors;
            return index;
        }
        
    }
}
