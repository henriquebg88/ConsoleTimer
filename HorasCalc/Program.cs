using HorasCalc.Model;
using HorasCalc.Services;

bool repetir = true;
bool resultados = true;
Periodo? periodo;
var periodos = new List<Periodo>();
ConsoleKeyInfo input;

while (repetir)
{
    ConsoleHelper.Clear();
    AppView.ShowMenu();

    if (resultados) AppView.ShowResults(periodos);
    
    Console.WriteLine("\nDigite um comando");

    input = Console.ReadKey();
    
    switch (input.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            periodo = Comandos.AddHorario();
            if (periodo != null) periodos.Add(periodo);
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            periodo = Comandos.Timer();
            if(periodo != null) periodos.Add(periodo);
            break;
        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:
            resultados = !resultados;
            break;
        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:
            periodos = [];
            break;
        case ConsoleKey.D5:
        case ConsoleKey.NumPad5:
            resultados = true;
            repetir = false;
            break;
        default:
            break;
    }

}





