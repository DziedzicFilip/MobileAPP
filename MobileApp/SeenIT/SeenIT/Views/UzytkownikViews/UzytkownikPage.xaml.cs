using SeenIT.ViewModels.FilmVM;
using SeenIT.ViewModels.UzytkownikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeenIT.Views.UzytkownikViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UzytkownikPage : ContentPage
    {
        UzytkownikViewModel _viewModel;
        public UzytkownikPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new UzytkownikViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}