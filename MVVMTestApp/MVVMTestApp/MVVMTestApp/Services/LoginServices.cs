using System;
using System.Collections.Generic;
using System.Text;
using MVVMTestApp.Model;

namespace MVVMTestApp.Services
{
    public class LoginServices
    {
        public List<LoginModel> GetLoginList()
        {
            List<LoginModel> list = new List<LoginModel>()
            {
                 new LoginModel()
                {
                     UserName = "user",
                     Password = "123321",                    
                },
                  new LoginModel()
                {
                     UserName = "developer",
                     Password = "123456"                    
                },                 
            };
            return list;
        }
    }
}
