namespace JogoDeAdvinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int chances = 0;
                Random randomNumeroAleatorio = new Random();
                int intNumeroAleatorio = Convert.ToInt32(randomNumeroAleatorio.Next(0, 20));
                int pontos = 1000;
                Console.WriteLine("******************************\n***** Jogo de Advinhação *****\n******************************");
                Console.WriteLine("Selecione a dificuldade:  (1) Fácil  (2) Médio  (3) Difícil");
                string dificuldade = Console.ReadLine();
                switch (dificuldade)
                {
                    case "1": chances = 15; break;
                    case "2": chances = 10; break;
                    case "3": chances = 5; break;
                }
                for (int i = 1; i <= chances; i++)
                {
                    Console.Write($"\n------------------------------ \nTentativa {i} de {chances}  \nChute um número: ");
                    int numeroChutado = Convert.ToInt32(Console.ReadLine());

                    if (numeroChutado > intNumeroAleatorio)
                    {
                        Console.WriteLine("Seu chute foi maior que o número secreto!");
                        pontos = pontos - Math.Abs(((numeroChutado - intNumeroAleatorio) / 2));
                        Console.WriteLine($"está com {pontos} pontos \n------------------------------");

                    }
                    if (numeroChutado < intNumeroAleatorio)
                    {
                        Console.WriteLine("Seu chute foi menor que o número secreto!");
                        pontos = pontos - Math.Abs(((numeroChutado - intNumeroAleatorio) / 2));
                        Console.WriteLine($"está com {pontos} pontos \n------------------------------");

                    }
                    if (numeroChutado == intNumeroAleatorio)
                    {
                        Console.WriteLine($"Acertou!\nTerminou com {pontos} pontos \n------------------------------");
                        continue;
                    }
                    else if (i == chances)
                    {
                        Console.WriteLine($"Acabou as chances! comece novamente.\nTerminou com {pontos} pontos \n------------------------------");
                        continue;
                    }
                }
                Console.ReadLine();
            }
        }
    }
}