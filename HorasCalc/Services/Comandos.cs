using HorasCalc.Model;
namespace HorasCalc.Services
{
    public static class Comandos
    {
        public static Periodo? AddHorario()
        {
            var repeat = true;

            while (repeat)
            {
                ConsoleHelper.Clear();
                AppView.ShowMenuInserir();

                Console.WriteLine("\nDigite um comando");

                var input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        return AddByHourMinute();
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        return AddByScale();
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.Escape:
                        return null;
                    default:
                        break;
                }
            }

            return null;
        }

        private static Periodo AddByHourMinute()
        {
            ConsoleHelper.Clear();
            Console.WriteLine("Digite a HORA inicial e pressione ENTER. Em seguida, digite o MINUTO e pressione ENTER.\n");

            Console.Write("hora:");
            var horaI = ConsoleHelper.ReadNumer(NumberType.Hour);
            Console.Write("minuto:");
            var minutoI = ConsoleHelper.ReadNumer(NumberType.Minutes);

            ConsoleHelper.Clear();

            Console.WriteLine($"Iniciou às {horaI} horas e {minutoI} minutos\n");

            Console.WriteLine("Digite a HORA de término e pressione enter. Em seguida, digite o MINUTO e pressione enter.");
            Console.Write("hora:");
            var horaF = ConsoleHelper.ReadNumer(NumberType.Hour);
            Console.Write("minuto:");
            var minutoF = ConsoleHelper.ReadNumer(NumberType.Minutes);

            ConsoleHelper.Clear();

            return new Periodo(horaI, minutoI, horaF, minutoF);
        }

        private static Periodo AddByScale()
        {
            ConsoleHelper.Clear();
            Console.WriteLine("Digite o período na escada de 1 e pressione ENTER");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Ex: 1,5 (equivale a 1h30) ou 1,60 (equivale a 1h36)\n");
            Console.ForegroundColor = ConsoleColor.White;

            double input = ConsoleHelper.ReadDouble();

            int minutes = Int32.Parse(Math.Round(input * 60).ToString());

            return new Periodo(0,0,0, minutes);
        }

        public static Periodo? Timer()
        {
            ConsoleKeyInfo keyInfo;

            ConsoleHelper.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Pressione qualquer tecla para iniciar o timer.");
            keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Escape) return null;

            ConsoleHelper.Clear();

            var inicio = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Iniciou às {inicio.Hour} horas e {inicio.Minute} minutos\n");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Pressione qualquer tecla para finalizar.");
            keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Escape) return null;

            ConsoleHelper.Clear();

            var fim = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Iniciou às {inicio.Hour} horas e {inicio.Minute} minutos");
            Console.WriteLine($"Finalizou às {fim.Hour} horas e {fim.Minute} minutos");
            var periodo = new Periodo(inicio.Hour, inicio.Minute, fim.Hour, fim.Minute);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nTempo decorrido de {periodo.GetDuracao()}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Pressione qualquer tecla para finalizar.");

            keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Escape) return null;

            Console.ForegroundColor = ConsoleColor.White;

            return periodo;
        }

        
    }

    
}
