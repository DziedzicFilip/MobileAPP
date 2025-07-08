using SeenIT.ViewModels.ReviewsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeenIT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddReview : ContentPage
    {
        public AddReview()
        {
            InitializeComponent();
            BindingContext = new AddReviewViewModel();
        }
    }
}