using System;

namespace ConsoleApp7

{
    class Pogram
    {
        static void A(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Нечётьное");
            }
            
        }
        static void Main(string[] args)
        {
            A(3);
            A(4);
            A(5);
            A(6);
            A(7);
        }
    }
}