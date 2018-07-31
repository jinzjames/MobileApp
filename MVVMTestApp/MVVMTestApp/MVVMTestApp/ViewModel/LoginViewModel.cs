using System;
using System.Collections.Generic;
using System.Text;
using MVVMTestApp.Services;
using MVVMTestApp.Model;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMTestApp.ViewModel
{
    public class LoginViewModel
    {
        LoginServices services;
        public ICommand LoginDetails { get; set; }

        public LoginViewModel()
        {
            LoginDetails = new Command(ButtonClicked);
        }

        private void ButtonClicked(object obj)
        {
            var view = obj as Button;
            string a =(string)view.CommandParameter;
        }

        public void GetLoginDetails()
        {
            List<LoginModel> loginlist = new List<LoginModel>();
            services = new LoginServices();
            loginlist = services.GetLoginList();
        }
    }
}
