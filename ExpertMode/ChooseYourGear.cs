/*using System;

namespace ExpertMode
{
    public class ChooseYourGear
    {
        public static bool erro = false;
        public static string[] itens = new string[]{"panela","travesseiro","pistola","corda","lança","metralhadora"};
        static void Main(string[] args)
        {   
            PrintAndWait("Chegou a hora de escolher seus itens em um apocalipse zumbi");
            PrintAndWait("Em sua frente temos vários itens, faça a sua escolha, você só pode carregar no máximo 3");
            Escolha(0,1);

            var escolhaDoJogador = Console.ReadLine();
            if(escolhaDoJogador == itens[0])
            {
                PrintAndWait($"Você escolheu {itens[0]}, com fome você nao fica");
            }
            else if(escolhaDoJogador == itens[1])
            {
                PrintAndWait($"Você escolheu {itens[1]}, não vai tirar uma soneca né!?");
            }
            else
            {
                PrintErro();
            }
            Escolha(2,3);

            var segundaEscolhaDoJogador = Console.ReadLine();
            if(segundaEscolhaDoJogador == itens[2])
            {
                PrintAndWait($"Você escolheu {itens[2]}, isso é perigoso, cuidado!");
            }
            else if(segundaEscolhaDoJogador == itens[3])
            {
                PrintAndWait($"Você escolheu {itens[3]}, Vai se enforcar? medroso!");
            }
            else
            {
                PrintErro();
            }
            Escolha(4,5);

            var terceiraEscolhaDoJogador = Console.ReadLine();
             if(terceiraEscolhaDoJogador == itens[4])
            {
                PrintAndWait($"Você escolheu {itens[4]}, cuidado pra nao furar o pé");
            }
            else if(terceiraEscolhaDoJogador == itens[5])
            {
                PrintAndWait($"Você escolheu {itens[5]}, Caraca,onde você achou uma dessa?");
            }
            else
            {
                PrintErro();
            }
            PrintFinal(escolhaDoJogador,segundaEscolhaDoJogador,terceiraEscolhaDoJogador);
        }
        
        static void PrintAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
        static void Escolha(int index, int index2)
        {
            
            Console.WriteLine($"Escolha {itens[index]} ou {itens[index2]}");
        }
        static void PrintErro()
        {
            Console.WriteLine("Voce Digitou algo errado");
            erro = true;
        }
        static void PrintFinal(string primeiraEscolha, string segundaEscolha,string terceiraEscolha)
        {
            if(erro == false)
            {
                Console.WriteLine($"Você escolheu {primeiraEscolha},{segundaEscolha},{terceiraEscolha}, é acho que voce consegue viver por uns 2 dias haha Boa sorte!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Você optou por não levar algo, resolvemos tirar tudo logo");
                Console.ReadKey();
            }
        }
    }
    
}*/

