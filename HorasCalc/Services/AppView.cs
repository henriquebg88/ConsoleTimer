using HorasCalc.Model;

namespace HorasCalc.Services
{
    public static class AppView
    {
        public static void ShowAppName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CALCULADORA DE HORAS!\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowMenu()
        {
            Console.WriteLine("1 - Inserir Manualmente");
            Console.WriteLine("2 - Timer");
            Console.WriteLine("3 - Exibir/Esconder resultado");
            Console.WriteLine("4 - Reiniciar");
            Console.WriteLine("5 - Finalizar");
        }

        public static void ShowMenuInserir()
        {
            Console.WriteLine("1 - Inserir por hora");
            Console.WriteLine("2 - Inserir por escala de 1");
            Console.WriteLine("3 - Finalizar");
        }

        public static void ShowResults(List<Periodo> periodos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPeríodos registrados:\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;

            foreach (var periodo in periodos)
            {
                Console.WriteLine($"\t- {periodo.GetPeriodo()} ({periodo.GetDuracao()}) | ({periodo.duracao.ToAzure()})");
            }

            if (periodos.Count > 0)
            {
                TimeSpan duracaoTotal = new TimeSpan(0);

                foreach (var periodo in periodos)
                {
                    duracaoTotal += periodo.duracao;
                }

                Console.WriteLine("\n----------------------------------------------------------------------");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Duração total: {duracaoTotal.ToHoraMinuto()} ({duracaoTotal.ToAzure()})");
            }
            else
            {
                Console.WriteLine("Nenhum período registrado.");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
