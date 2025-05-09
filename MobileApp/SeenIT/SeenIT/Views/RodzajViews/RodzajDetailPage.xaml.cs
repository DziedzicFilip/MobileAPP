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
    public partial class RodzajDetailPage : ContentPage
    {
        public RodzajDetailPage()
        {
            InitializeComponent();
            BindingContext = new RodzajDetailsViewModel();
        }
    }
}