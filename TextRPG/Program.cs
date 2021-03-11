using System;
using RPGObjects;
namespace TextRPG
{
    class Program
    {
        static void Main(string[] args) {
            Player player = new Player("") ;
            PlayerSetup(player);
        }

        static void PlayerSetup(Player player)
        {
            Console.WriteLine("Please fill in your character name: ");
            player.Name = Console.ReadLine();
            Console.WriteLine(player.Name);
        }
    }
}
