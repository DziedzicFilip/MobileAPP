using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeenIT.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeenIT.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ObjectPage : ContentPage
	{
		public ObjectPage ()
		{
			InitializeComponent ();
            BindingContext = new ObjectViewModel();
        }
	}
}