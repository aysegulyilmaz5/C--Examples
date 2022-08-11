using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Identity ıd = new Identity();
            ıd.NAME = "Aysegul";
            ıd.SURNAME = "Yilmaz";
            Console.WriteLine(ıd.NAME);
            Console.WriteLine(ıd.SURNAME);
            Console.WriteLine(ıd.BORN);
            Console.WriteLine(ıd.AGE);
            Console.WriteLine(ıd.GENDER);
            Console.Read();
        }
    }
}
