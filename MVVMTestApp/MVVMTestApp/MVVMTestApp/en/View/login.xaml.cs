using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMTestApp.en.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class login : ContentPage
	{
		public login ()
		{
			InitializeComponent ();            
        }
        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }

        async void Login_Btn_Clicked(object sender, EventArgs e)
        {
            string UserName = "user";
            string Password = "123456";            

            if(UserName == username.Text && Password == password.Text)
            {
                await Navigation.PushAsync(new Customer());
            }
            else
            {
                await DisplayAlert("Invalid Login", "Invalid UserName & Password", "OK");
            }
        }
    }
}