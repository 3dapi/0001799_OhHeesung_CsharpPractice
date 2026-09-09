using System.ComponentModel.DataAnnotations;

namespace CsharpPractice03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var inputString = Console.ReadLine();
            //Console.WriteLine(inputString);

            var val1 = 1000;
            var val2 = 2000;

            long valc = val1 + val2;
            float valf = valc;
            double vald = valf;

            valf = (float)vald;
            valc = (long)valf;
            val1 = (int)valc;

            //var str = "20000";
            //val1 = int.Parse(str);  Console.WriteLine(val1);
            //valc = long.Parse(str);

            //val1.ToString();
            //valc.ToString();
            //valf.ToString();
            //vald.ToString();
            //var str2 = val1 + ""; Console.WriteLine($"str2: type {str2.GetType()}");

            //var b1 = bool.Parse("TRUE");  Console.WriteLine($"b1: type {b1.GetType()}: {b1}");
            //var b2 = bool.Parse("False"); Console.WriteLine($"b2: type {b2.GetType()}: {b2}");
            //var b3 = bool.Parse("tRUE");  Console.WriteLine($"b3: type {b3.GetType()}: {b3}");

            int valMin = int.MinValue; Console.WriteLine(valMin);
            valMin = -2147483648;
            Console.WriteLine(-valMin);
            //int valMax = int.MaxValue; Console.WriteLine(valMax);
        }
    }
}
