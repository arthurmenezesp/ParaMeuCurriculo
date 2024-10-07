using System;

class Program
{
    static Random random = new Random();
    static int[] resultados = new int[6];  

    
    static int LancarDado()
    {
        return random.Next(1, 7);  
    }

  
    static void ExibirProbabilidades(int totalLancamentos)
    {
        Console.WriteLine("\nProbabilidades:");
        for (int i = 0; i < 6; i++)
        {
            double probabilidade = (double)resultados[i] / totalLancamentos * 100;
            Console.WriteLine($"Face {i + 1}: {probabilidade:F2}% ({resultados[i]} vezes)");
        }
    }

    static void Main(string[] args)
    {
        int totalLancamentos = 0;
        int opcao = 0;

        do
        {
            Console.WriteLine("\nSimulador de Jogo de Dados");
            Console.WriteLine("1. Lançar dado");
            Console.WriteLine("2. Exibir resultados");
            Console.WriteLine("3. Exibir probabilidades");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    int resultado = LancarDado();
                    Console.WriteLine($"Você lançou o dado e saiu: {resultado}");
                    resultados[resultado - 1]++;
                    totalLancamentos++;
                    break;

                case 2:
                    Console.WriteLine("\nResultados até agora:");
                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine($"Face {i + 1}: {resultados[i]} vezes");
                    }
                    break;

                case 3:
                    if (totalLancamentos > 0)
                    {
                        ExibirProbabilidades(totalLancamentos);
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dado foi lançado ainda.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Encerrando o simulador...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 4);
    }
}