using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random jogada = new Random();

            int Cara=0, Coroa=0;
            int Joga=1, Placa=2, Fim=3;

            Console.WriteLine("*-------------------------*");
            Console.WriteLine("*  Jogo de cara ou coroa  *");
            Console.WriteLine("*                         *");
            Console.WriteLine("*Jogar  <1>               *");
            Console.WriteLine("*Placar <2>               *");
            Console.WriteLine("*Fim    <3>               *");
            Console.WriteLine("*-------------------------*");

            Next.
            for (int i = 1; i < 10; i++)
            {
                if ()
                {
                    Console.WriteLine("Cara");
                    string descricao1 = "cara";
                }
                else
                {
                    Console.WriteLine("Coroa");
                    string descricao2 = "coroa";
                }
            }

            if (Joga != 1)
            {
                Console.WriteLine("Jogar < 1 >");

            }    
                if (Placa != 2)
                {
                    Console.WriteLine("Placar < 2 >");
                    Console.WriteLine("*-------------------------*");
                    Console.WriteLine("*         Placar          *");
                    Console.WriteLine("*                         *");
                    Console.WriteLine("*Jogar  <1>               *");
                    Console.WriteLine("*Placar <2>               *");
                    Console.WriteLine("*Fim    <3>               *");
                    Console.WriteLine("*-------------------------*");
                }
                if (Fim != 3)
                {
                    Console.WriteLine("Fim < 3 >");
                }


                Console.WriteLine("Digite a opçao que deseja executar:");
                int Menu = int.Parse(Console.ReadLine());




            
        }
    }
}
