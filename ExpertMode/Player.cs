using System;
using System.Collections.Generic;

namespace ExpertMode
{
    public class Player
    {
        public static string PlayerName{get; private set;}
        public static int Coins{get; internal set;}
        public static List<Item> Bag = new List<Item>();

        public Player(string playerName, int coins)
        {
            PlayerName = playerName;
            Coins = coins;
        }
        static public void EnterPlayer()
        {
            Console.WriteLine("Whats your name?");
            var _playerName = Console.ReadLine();
            Console.WriteLine("How much coins do you have?");
            var coinQuantity = Console.ReadLine();
            int _coinQuantity;
            Int32.TryParse(coinQuantity, out _coinQuantity);
            var player = new Player(_playerName,_coinQuantity);
        }

        static public void ShowItensInBag()
        {
            Console.WriteLine("These are your items");
            foreach (Item item in Bag)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
    }
}