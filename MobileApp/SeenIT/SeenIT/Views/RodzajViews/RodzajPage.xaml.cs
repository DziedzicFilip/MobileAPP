using SeenIT.ViewModels.FilmVM;
using SeenIT.ViewModels.RodzajVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeenIT.Views.RodzajViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RodzajPage : ContentPage
    {
        RodzajViewModel _viewModel;
        public RodzajPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new RodzajViewModel();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}