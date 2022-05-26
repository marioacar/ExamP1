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
    public partial class DetallesGeneral : ContentPage
    {
        public DetallesGeneral(Movie movie)
        {
            InitializeComponent();
            BindingContext = new DetallesGeneralViewModel(movie);

        }
    }
}