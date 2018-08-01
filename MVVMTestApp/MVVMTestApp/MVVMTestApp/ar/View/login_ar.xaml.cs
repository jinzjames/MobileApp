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
	public partial class login_ar : ContentPage
	{
		public login_ar ()
		{
			InitializeComponent ();
		}
        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signup_ar());
        }

        async void Login_Btn_Clicked(object sender, EventArgs e)
        {
            string UserName = "المستعمل";
            string Password = "123456";

            if (UserName == username.Text && Password == password.Text)
            {
                await Navigation.PushAsync(new customer_ar());
            }
            else
            {
                await DisplayAlert("Invalid Login", "Invalid UserName & Password", "OK");
            }
        }     
    }
}