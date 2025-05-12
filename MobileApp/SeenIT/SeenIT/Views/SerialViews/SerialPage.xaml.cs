using SeenIT.ViewModels.SerialVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeenIT.Views.SerialViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SerialPage : ContentPage
    {
        SerialViewModel _viewModel;
        public SerialPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SerialViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

    }
}