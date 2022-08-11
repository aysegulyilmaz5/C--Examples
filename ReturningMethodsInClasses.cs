using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            op.sum(7, 6);
            op.sum(4, 5);
            op.square(5);
            op.square(8);
            Console.Read();

        }
    }
}
