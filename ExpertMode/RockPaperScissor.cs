/*using System;

namespace ExpertMode
{
    public class RockPaperScissor
    {
        enum MyChoice
        {
            rock,
            paper,
            scissor,
            water
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to machines world...");
            Console.ReadKey();
            Console.WriteLine("Only one truth exist, you will lose...");
            Console.ReadKey();
            Console.WriteLine("Make Your Choice, We Are playing rock,paper,scissor!");
            string myChoiceString = Console.ReadLine();
            MyChoice myChoice;
            bool sucess = Enum.TryParse<MyChoice>(myChoiceString, out myChoice);
            
            if(sucess)
            {
                switch (myChoice)
            {
                case MyChoice.rock:
                    Console.WriteLine("I Chose Paper. Your Loser haha");
                    break;
                case MyChoice.paper:
                    Console.WriteLine("I Chose Scissor.Your Loser haha");
                    break;
                case MyChoice.scissor:
                    Console.WriteLine("I Chose Rock. Your Loser haha ");
                    break;
                default:
                    Console.WriteLine("Something Strange Happened, Whaaat youuu d... (silece)");
                    break;
            }
            Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your idiot, play correctly");
                Console.ReadKey();
            }
        }
    }
}*/