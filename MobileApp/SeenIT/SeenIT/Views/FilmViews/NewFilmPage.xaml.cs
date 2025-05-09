using SeenIT.ViewModels.FilmVM;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeenIT.Views.FilmViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewFilmPage : ContentPage
    {
        public NewFilmPage()
        {
            InitializeComponent();
            BindingContext = new NewFilmViewModel();
        }
    }
}