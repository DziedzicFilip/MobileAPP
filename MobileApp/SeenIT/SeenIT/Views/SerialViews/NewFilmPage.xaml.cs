using SeenIT.ViewModels.SerialVM;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeenIT.Views.SerialViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewSerialPage : ContentPage
    {
        public NewSerialPage()
        {
            InitializeComponent();
            BindingContext = new NewSerialViewModel();
        }
    }
}