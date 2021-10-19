/*using System;
using System.Collections.Generic;

namespace ExpertMode
{   public class Item
    {   public string nome;
        public int preço;
        public Item(string nome, int preço)
        {
            this.nome = nome;
            this.preço = preço;
        }
    }
    public class DesafioClasses
    {
        public static int coins = 5;
        static void Main(string[] args)
        {
            Item espada = new Item("1-espada",1);
            Item escudo = new Item("2-escudo",2);
            Item balde = new Item("3-balde",3);
            List<string> itensAdquiridos = new List<string>();

            Console.WriteLine("Olá, Você por aqui novamente...");
            while(coins > 0)
            {
                Console.WriteLine("Quais itens deseja adquirir?");
                Console.WriteLine($"Você tem {coins}");
                Console.WriteLine($"{espada.nome+" "+espada.preço+"$"}, {escudo.nome+" "+escudo.preço+"$"}, {balde.nome+" "+balde.preço+"$"}");
                var escolhaDoJogador = Console.ReadLine();
                if(escolhaDoJogador == "1" && coins >= 1)
                {
                    coins -= 1;
                    itensAdquiridos.Add("espada");
                }
                else if(escolhaDoJogador == "2" && coins >= 2)
                {
                    coins -= 2;
                    itensAdquiridos.Add("escudo");
                }
                else if(escolhaDoJogador == "3" && coins >= 3)
                {
                    coins -= 3;
                    itensAdquiridos.Add("balde");
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