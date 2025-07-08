using SeenIT.ViewModels;
using Xamarin.Forms;

namespace SeenIT.Views.WatchedViews
{
    public partial class WatchedView : ContentPage
    {
        public WatchedView()
        {
            InitializeComponent();
            BindingContext = new WatchedViewModel();
        }
    }
}
