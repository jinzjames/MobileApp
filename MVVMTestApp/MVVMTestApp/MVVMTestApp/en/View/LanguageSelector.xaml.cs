using MVVMTestApp.ar.View;
using MVVMTestApp.en.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMTestApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanguageSelector : ContentPage
    {
        public LanguageSelector()
        {
            InitializeComponent();
        }

        async void lang_btn_Clicked(object sender, EventArgs e)
        {
            int index = lang.SelectedIndex;
            if (index == -1)
            {
                await DisplayAlert("Alert", "Please Choose Preferred Language", "OK");
            }
            else
            {
                string language = lang.Items[lang.SelectedIndex];

                if (language == "English")
                    await Navigation.PushAsync(new login());
                else
                    await Navigation.PushAsync(new login_ar());
            }
        }
    }
}