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
    public partial class EditUzytkownikPage : ContentPage
    {
        public EditUzytkownikPage()
        {
            InitializeComponent();
            BindingContext = new EditUzytkownikViewModel();

        }
    }
}