using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorasCalc.Services
{
    public static class Extensions
    {
        public static double ToAzure(this TimeSpan timeSpan) => Math.Round(timeSpan.Hours + (timeSpan.Minutes * 0.017), 2);
        public static string ToHoraMinuto(this TimeSpan timeSpan) => timeSpan.ToString(@"hh\hmm");
    }
}
