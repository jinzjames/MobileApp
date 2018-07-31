using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MVVMTestApp.Model;
using MVVMTestApp.Services;
using Xamarin.Forms;

namespace MVVMTestApp.ViewModel
{
    public class CustomerViewModel : ViewModelBase
    {
        CustomerServices services;
        private List<Customer> customerList;
        public List<Customer> list {
            get {return customerList; }
            set { SetProperty(ref customerList, value); }
        }
        public CustomerViewModel()
        {
            services = new CustomerServices();          

            ListCommand = new Command(GetCustomerList, CanCustomerList);
        }

        private bool CanCustomerList()
        {
            if (list == null)
                return true;
            else
                return false;
        }

        private void GetCustomerList()
        {
            services = new CustomerServices();
            list = services.GetCustomerList();
            ((Command)ListCommand).ChangeCanExecute();
        }

        public ICommand ListCommand { get; set; }
    }
}
