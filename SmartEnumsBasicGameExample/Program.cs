using System;

namespace SmartEnumsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, insert a value from mobile entity to get actions!");
            var value = Console.ReadLine();


            var character = MobileEntity.FromValue(Convert.ToInt32(value));

            Console.WriteLine($"Actions for {character.Name} ");
            Console.WriteLine($"Can Run:  {character.CanRun} ");
            Console.WriteLine($"Can Talk:  {character.CanTalk} ");
            Console.WriteLine($"Can Build:  {character.CanBuild} ");
            Console.WriteLine($"Can Attack:  {character.CanAttack} ");
        }
    }
}
