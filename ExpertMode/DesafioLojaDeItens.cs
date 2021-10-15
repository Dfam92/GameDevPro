/*using System;

namespace ExpertMode
{
    public class DesafioLojaDeItens
    {
        public static string[] itens = {"Espada - 1 Coin","Escudo - 1 Coin","Adaga - 1 Coin"};
        public static int coins = 5;
        public static int count;
        static void Main(string[] args)
        {
            string[] playerItens = new string[5];
            Console.WriteLine("Bem Vindo a Loja!");
            Console.WriteLine("Temos vários itens a sua disposição");
            Console.ReadKey();
            for(int i = 0; i<itens.Length; i++)
            {
                Console.WriteLine(itens[i]);
            }
            while (coins > 0)
            {
               
                Console.WriteLine("Qual item você deseja comprar?");
                Console.WriteLine("[0] Espada, [1] Escudo, [2] Adaga");
                var escolhaDoJogador = Console.ReadLine();
                if (escolhaDoJogador == "0")
                {   playerItens[count] = "espada";
                    escolhaDoJogador = itens[0];
                    coins -= 1;
                    count++;
                }
                else if (escolhaDoJogador == "1")
                {
                    playerItens[count] = "escudo";
                    escolhaDoJogador = itens[1];
                    coins -= 1;
                    count++;
                }
                else if (escolhaDoJogador == "2")
                {
                    playerItens[count] = "Adaga";
                    escolhaDoJogador = itens[2];
                    coins -= 1;
                    count++;
                }
                else
                {
                    Console.WriteLine("Você digitou algo errado! Tente novamente");
                    continue;
                }
            }
            Console.WriteLine("Obrigado por gastar todo seu dinheiro!");
            Console.WriteLine($"Esse foram seus itens ");
            for(int n = 0; n < playerItens.Length; n++)
            {
                Console.WriteLine($"{playerItens[n]}");
            }
            Console.ReadLine();
        }
    }
}*/