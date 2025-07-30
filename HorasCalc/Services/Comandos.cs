using HorasCalc.Model;
namespace HorasCalc.Services
{
    public static class Comandos
    {
        public static Periodo AddHorario()
        {
            ConsoleHelper.Clear();
            Console.WriteLine("Digite a HORA inicial e pressione enter. Em seguida, digite o MINUTO e pressione enter.\n");

            Console.Write("hora:");
            var horaI = ConsoleHelper.ReadNumer(NumberType.Hour);
            Console.Write("minuto:");
            var minutoI = ConsoleHelper.ReadNumer(NumberType.Minutes);

            ConsoleHelper.Clear();

            Console.WriteLine($"Iniciou às {horaI} horas e {minutoI} minutos\n");

            Console.WriteLine("Digite a HORA de término e pressione enter. Em seguida, digite o MINUTO e pressione enter.");
            var horaF = ConsoleHelper.ReadNumer(NumberType.Hour);
            Console.Write("hora:");
            var minutoF = ConsoleHelper.ReadNumer(NumberType.Minutes);
            Console.Write("minuto:");

            ConsoleHelper.Clear();

            return new Periodo(horaI, minutoI, horaF, minutoF);
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
