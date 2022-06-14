using System;
using System.Collections.Generic;


namespace ConsoleITVDN
{
    class Program
    {
        public static void Main()
        {
            List<User> listuser = new List<User>
            {
             new User { Name = "Roman", Login = "123", IsPremium = true },

             new User { Name = "Igor", Login = "453", IsPremium = false },

             new User { Name = "Ivan", Login = "567", IsPremium = true },
            };


            foreach (var item in listuser)
            {
                if (item.IsPremium == true)
                    Console.WriteLine($"Hello {item.Name}");
                else
                   User.ShowAds();

            }
        }
    }
}

    
