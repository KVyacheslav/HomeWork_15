using System;

namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();

            prog.PrintDateTimeNow();

            "Hello World".Print();

            10.MathPow().Print();
        }
    }
}
