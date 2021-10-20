using System;

namespace ExpertMode
{
    class DesafioFinal
    {
        static void Main(string[] args)
        {
            Player.EnterPlayer();
            Store.PrintGreeting();
            Store.ExecuteStoreLoop();
            Player.ShowItensInBag();
        }
    }
}