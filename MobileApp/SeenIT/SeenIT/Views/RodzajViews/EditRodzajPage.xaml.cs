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
    public partial class EditRodzajPage : ContentPage
    {
        public EditRodzajPage()
        {
            InitializeComponent();
            BindingContext = new EditRodzajViewModel();

        }
    }
}