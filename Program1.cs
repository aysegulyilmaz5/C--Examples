using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inf;
            Console.Write("Name - Club:");
            inf = Console.ReadLine();
            Student student = new Student("Ayşegül - Yılmaz");
            Console.Read();
        }
    }
}
