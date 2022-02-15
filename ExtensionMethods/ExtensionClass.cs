using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionClass
    {
        public static void PrintDateTimeNow(this Program program)
        {
            var text = $"Дата и время сейчас: {DateTime.Now:g}.";
            Console.WriteLine(text);
        }

        public static void Print(this string txt)
        {
            Console.WriteLine(txt);
        }

        public static string MathPow(this int x)
        {
            return (x * x).ToString();
        }
    }
}
