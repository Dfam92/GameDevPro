using System;

namespace ExpertMode
{
    public class Store
    {
        public static Item item1 = new Item("1","Sword",1);
        public static Item item2 = new Item("2","Shield",2);
        public static Item item3 = new Item("3","Gun",3);
        public static void PrintGreeting()
        {
            Console.WriteLine($"Hi,{Player.PlayerName} You have {Player.Coins} coins ");
            Console.ReadKey();
        }
        public static void ExecuteStoreLoop()
        {
            
            Console.WriteLine();
            Console.WriteLine("I have these Itens:");
            
            while(Player.Coins > 0)
            {

                ListOfItens();
                var mychoice = Console.ReadLine();
                if(mychoice == item1.Id)
                {
                    Player.Coins -= 1;
                    Player.Bag.Add(item1);
                }
                else if(mychoice == item2.Id && Player.Coins > 1)
                {
                    Player.Coins -= 2;
                    Player.Bag.Add(item2);
                }
                else if(mychoice == item3.Id  && Player.Coins > 2)
                {
                    Player.Coins -= 3;
                    Player.Bag.Add(item3);
                }
                else
                {
                    Console.WriteLine("You don't have money for this");
                }

                if(Player.Coins != 0)
                {
                    Console.WriteLine($"You still have {Player.Coins} Coins, You need to shop more!");
                }
                
            }
            Console.WriteLine("Thanks for buying my items!");
            Console.ReadKey();
            
        }
        public static void ListOfItens()
        {
            Console.WriteLine($"{item1.Id}-{item1.Name} {item1.Price}$");
            Console.WriteLine($"{item2.Id}-{item2.Name} {item2.Price}$");
            Console.WriteLine($"{item3.Id}-{item3.Name} {item3.Price}$");
            Console.WriteLine("Which item do you want?");
        }
    }
}