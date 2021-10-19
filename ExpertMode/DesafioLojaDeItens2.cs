/*using System;
using System.Collections.Generic;

namespace ExpertMode
{
    public class DesafioLojaDeItens2
    {   
        public static int coins = 5;
        static void Main(string[] args)
        {
            List<string> itensAdquiridos = new List<string>();

            Console.WriteLine("Olá, Você por aqui novamente...");
            while(coins > 0)
            {
                Console.WriteLine("Quais itens deseja adquirir?");
                Console.WriteLine($"Você tem {coins}");
                Console.WriteLine("1.Espada : 1$, 2.Escudo : 2$, 3.Balde : 3$");
                var escolhaDoJogador = Console.ReadLine();
                if(escolhaDoJogador == "1" && coins >= 1)
                {
                    coins -= 1;
                    itensAdquiridos.Add("Espada");
                }
                else if(escolhaDoJogador == "2" && coins >= 2)
                {
                    coins -= 2;
                    itensAdquiridos.Add("Escudo");
                }
                else if(escolhaDoJogador == "3" && coins >= 3)
                {
                    coins -= 3;
                    itensAdquiridos.Add("Balde");
                }
                else
                {
                    Console.WriteLine("Você não tem dinheiro pra comprar isso");
                    continue;
                }
            }
            Console.WriteLine($"Esse são seus itens:");
            for(int i = 0; i < itensAdquiridos.Count; i++)
            {
                Console.WriteLine($"{itensAdquiridos[i]}");
            }
            Console.WriteLine("Obrigado por comprar!");
            Console.ReadKey();
        }
    }
}*/