using System;

namespace HelloMyGalaxy{
    class Program{
        static void Main(){
            Console.WriteLine("Hello galaxies!");
        }
    }

    class SaysHello{

        public static void WhoSaysHello(){
         Console.Write("Who says Hello ? : ");
         var line1 = Console.ReadLine();

         Console.WriteLine("BREAKING NEWS");
         Console.WriteLine($"{line1} says HELLO");

         return;
        }
    }
}