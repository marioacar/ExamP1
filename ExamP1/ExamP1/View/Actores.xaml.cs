using ExamP1.Model;
using ExamP1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamP1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Actores : ContentPage
    {
        public Actores(Actor actor)
        {
            InitializeComponent();

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}