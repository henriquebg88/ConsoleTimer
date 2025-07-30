namespace HorasCalc.Services
{
    public static class ConsoleHelper
    {
        public static int ReadNumer(NumberType type = NumberType.Any)
        {
            bool success = false;
            int number = 0;

            while (!success)
            {
                success = Int32.TryParse(Console.ReadLine(), out number);
                success = ValidateNumber(type, number);

                if (!success) Console.WriteLine("Insira um número válido.");
            }

            return number;
        }

        private static bool ValidateNumber(NumberType type, int number)
        {
            switch (type)
            {
                case NumberType.Any:
                    return true;
                case NumberType.Hour:
                    if(number > 24 || number < 0) return false;
                    break;
                case NumberType.Minutes:
                    if (number > 60 || number < 0) return false;
                    break;
                default:
                    return false;
            }

            return true;
        }

        public static void Clear()
        {
            Console.Clear();
            AppView.ShowAppName();
        }
    }

    public enum NumberType
    {
        Any = 1,
        Hour = 2,
        Minutes = 3
    }
}
