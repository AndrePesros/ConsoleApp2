using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random jogada = new Random();

            int Cara = 1, Coroa = 2;
            int opcao=0;

            Console.WriteLine("*-------------------------*");
            Console.WriteLine("*  Jogo de cara ou coroa  *");
            Console.WriteLine("*                         *");
            Console.WriteLine("*Jogar  <1>               *");
            Console.WriteLine("*Placar <2>               *");
            Console.WriteLine("*Fim    <3>               *");
            Console.WriteLine("*-------------------------*");

            

            if (opcao != 1)
            {
                Console.WriteLine("Jogar < 1 >");

                Console.WriteLine("Placar < 2 >");
                Console.WriteLine("*-------------------------*");
                Console.WriteLine("*         Jogar           *");
                Console.WriteLine("*                         *");
                Console.WriteLine("*Escolha cara ou coroa:   *");
                Console.WriteLine("*                         *");
                Console.WriteLine("* Cara     <1>            *");
                Console.WriteLine("* Ccoroa   <2>            *");
                Console.WriteLine("*                         *");
                Console.WriteLine("*-------------------------*");

                Console.WriteLine("Digite a opção: ");
                int escolha = int.Parse(Console.ReadLine());

                int s = jogada.Next(Cara, Coroa);
                
                for (s = 1; s < 2; s++)
                {
                    if (escolha == s)
                    {
                        Console.WriteLine("Cara");
                        Cara = 1;
                    }
                    else
                    {
                        Console.WriteLine("Coroa");
                        Coroa = 2;
                    }
                }
            }
            int cara = Cara++;
            int coroa = Coroa++;

                if (opcao != 2)
                {
                    Console.WriteLine("Placar < 2 >");
                    Console.WriteLine("*-------------------------*");
                    Console.WriteLine("*         Placar          *");
                    Console.WriteLine("*                         *");
                    Console.WriteLine("* Coroa {0}               *", coroa);
                    Console.WriteLine("* Cara  {0}               *", cara);
                    Console.WriteLine("*                         *");
                    Console.WriteLine("*-------------------------*");
                }
                if (opcao != 3)
                {
                    Console.WriteLine("Fim < 3 >");
                }


                Console.WriteLine("Digite a opçao que deseja executar:");
                opcao = int.Parse(Console.ReadLine());

            

            Console.ReadKey(opcao != 3);
            
        }
    }
}
