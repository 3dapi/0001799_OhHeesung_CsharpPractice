namespace chapter04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ~100 짝수 출력");
            for (var i = 1; i <= 100; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("0 ~10 while 작성");
            var start = 0;
            while(start <=10)
            {
                Console.WriteLine(start);
                ++start;
            }
        }
    }
}
