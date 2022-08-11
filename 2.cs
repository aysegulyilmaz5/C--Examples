using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            string name1;
            Console.Write("Enter name:");
            name1 = Console.ReadLine();
            user.User_name(name1);
            string surname1;
            Console.Write("Enter a surname:");
            surname1 = Console.ReadLine();
            user.User_surname(surname1);
            string job1;
            Console.Write("Enter a job:");
            job1 = Console.ReadLine();
            user.User_job(job1);
            Console.Read();
        }
    }
}
