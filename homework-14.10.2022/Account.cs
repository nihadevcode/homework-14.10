using System;
using System.Collections.Generic;
using System.Text;

namespace homework_14._10._2022
{
    class Account
    {
        public string username;
        public string password;
        public static string Login()
        {
            Account user1 = new Account();
            user1.username = Console.ReadLine();
            user1.password = Console.ReadLine();

            if (user1.username == "cavid123" && user1.password == "Cavid1993")
            {
                return ("Login successfull");
            }
            return ("Username or Password is incorrect");
        }
    }
}