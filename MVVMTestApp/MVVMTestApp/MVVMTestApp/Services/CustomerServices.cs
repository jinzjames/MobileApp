using System;
using System.Collections.Generic;
using System.Text;
using MVVMTestApp.Model;

namespace MVVMTestApp.Services
{
    public class CustomerServices
    {               
        public List<Customer> GetCustomerList()
        {
            List<Customer> list = new List<Customer>()
            {
                 new Customer()
                {
                     FirstName = "Jincy",
                     LastName = "James",
                     Image = "http://lorempixel.com/100/100/people/2"
                },
                  new Customer()
                {
                     FirstName = "Rakhi",
                     LastName = "Nair",
                     Image = "http://lorempixel.com/100/100/people/1"
                },
                   new Customer()
                {
                     FirstName = "Alan",
                     LastName = "Salim",
                     Image = "http://lorempixel.com/100/100/people/2"
                }
            };
            return list;
        }
    }
}
