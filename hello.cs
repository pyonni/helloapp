using System;

namespace HelloAppBlack
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            greetWhite();
        }

        static void SayHello()
        {
            Console.WriteLine("hello everyone");
        }

        static void greetWhite()
        {
            Console.WriteLine("hello white");
        }

        static void greetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}