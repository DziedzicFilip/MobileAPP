using SeenIT.ViewModels.FilmVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeenIT.Views.FilmViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditFilmPage : ContentPage
    {
        public EditFilmPage()
        {
            InitializeComponent();
            BindingContext = new EditFilmViewModel();
        }
    }
}