using System;

namespace ConsoleApp72

{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(10, 20);
            Console.WriteLine($"x = {p.X}, y = {p.Y}");
            
            graphik2D g2d = new graphik2D(30, 20);
            Console.WriteLine($"x = {g2d.X}, y = {g2d.Y}");
            
            Graphik g3 = new Graphik(30, 20, 70);
            Console.WriteLine($"x = {g3.X}, y = {g3.Y},z = {g3.getZ()}");
        }
    }
}