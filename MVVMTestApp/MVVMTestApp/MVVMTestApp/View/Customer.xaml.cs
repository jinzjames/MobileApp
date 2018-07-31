using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVMTestApp.ViewModel;

namespace MVVMTestApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Customer : ContentPage
	{
		public Customer ()
		{
			InitializeComponent ();

            BindingContext = new CustomerViewModel();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            CustomerViewModel model = new CustomerViewModel();           
            await Navigation.PushAsync(new Details());
        }
    }
}