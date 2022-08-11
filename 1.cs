using System;

namespace NotReturningMethodsInClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Users us = new Users();
            string ads;
            Console.Write("Enter a name:");
            ads = Console.ReadLine();
            us.User_List(ads);
            Console.Read();
        }
    }
}
