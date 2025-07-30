using HorasCalc.Services;

namespace HorasCalc.Model
{
    public class Periodo
    {
        private TimeSpan inicio;
        private TimeSpan fim;

        public Periodo(int horaI, int minutoI, int horaF, int minutoF)
        {
            inicio = new TimeSpan(horaI, minutoI, 0);
            fim = new TimeSpan(horaF, minutoF, 0);
        }

        public string GetDuracao() => (fim - inicio).ToHoraMinuto();
        public string GetPeriodo() => $"{inicio.ToHoraMinuto()} às {fim.ToHoraMinuto()}";
        public TimeSpan GetDuracaoTimeSpan() => fim - inicio;
    }
}
