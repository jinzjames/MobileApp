using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMTestApp.ar.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Signup_ar : ContentPage
	{
		public Signup_ar ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked3(object sender, EventArgs e)
        {
            DisplayAlert("Server Error", "Sorry try again sometimes", "Close");
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new login_ar());
        }
    }
}