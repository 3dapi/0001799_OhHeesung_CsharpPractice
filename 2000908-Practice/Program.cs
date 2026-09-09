
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 100;
            //int b = 200;
            //System.Console.WriteLine(a == b);
            //System.Console.WriteLine(a != b);
            //System.Console.WriteLine(a < b);
            //System.Console.WriteLine(a > b);
            //System.Console.WriteLine(a >= b);
            //System.Console.WriteLine(a <= b);

            //System.Console.WriteLine(a + b);
            //System.Console.WriteLine(a - b);
            //System.Console.WriteLine(a * b);
            //System.Console.WriteLine(a / b);
            //System.Console.WriteLine(a % b);

            //System.Console.WriteLine(sizeof(byte));
            //System.Console.WriteLine(sizeof(char));
            //System.Console.WriteLine(sizeof(short));
            //System.Console.WriteLine(sizeof(int));
            //System.Console.WriteLine(sizeof(long));
            //System.Console.WriteLine(sizeof(float));
            //System.Console.WriteLine(sizeof(double));

            //char value1 = 'a' = 'A' + 32;
            //char value2 = 'A';

            //System.Console.WriteLine(value1 + value2);
            //System.Console.WriteLine(value1 - value2);
            //System.Console.WriteLine(value1 * value2);
            //System.Console.WriteLine(value1 / value2);
            //System.Console.WriteLine(value1 % value2);
            //char value2 = '0';
            //System.Console.WriteLine(value2 - 0);

            //System.Console.WriteLine(sizeof(byte));
            //System.Console.WriteLine(sizeof(char));
            //System.Console.WriteLine(sizeof(int));
            //System.Console.WriteLine(sizeof(long));
            //System.Console.WriteLine(sizeof(float));
            //System.Console.WriteLine(sizeof(double));

            //                 0  1 2 3 4
            //string message1 = "안녕하세요. 방갑습니다.";

            //Console.WriteLine(message1[0]);
            //Console.WriteLine(message1[1]);
            //Console.WriteLine(message1[2]);
            //Console.WriteLine(message1[3]);
            //Console.WriteLine(message1[4]);

            //int value3 = 12345;
            //value3 += 200; Console.WriteLine(value3);
            //value3 -= 200; Console.WriteLine(value3);
            //value3 *= 200; Console.WriteLine(value3);
            //value3 /= 200; Console.WriteLine(value3);
            //value3 %= 200; Console.WriteLine(value3);

            //string m1 = "Hello";
            //m1 += " world";

            //string resDir = "resource/";
            //string textureFile = "m1.png";
            //string texPath = resDir;
            //texPath += textureFile;
            //Console.WriteLine(texPath);

            //// 단항 연산자
            //int value = 100;
            //int result = 0;

            //result = ++value;
            //Console.WriteLine($"result: {result} value: {value}");    // value += 1;

            //result = value++;
            //Console.WriteLine($"result: {result} value: {value}");    // value += 1;

            //// value++;
            //// result = value;
            //// value = value+1;

            //result = --value; Console.WriteLine($"result: {result} value: {value}");    // value -= 1;
            //result = value--; Console.WriteLine($"result: {result} value: {value}");    // value -= 1;

            //// value--;
            //// result = value;
            //// value = value-1;
            ///
            /// GetType

            //Console.WriteLine(10.GetType());
            //Console.WriteLine(10.0F.GetType());
            //Console.WriteLine('한'.GetType());
            //Console.WriteLine("message".GetType());

            //int value = "안녕하세요";
            //Console.WriteLine("value type: " + value.GetType());


            long val10 = 0L        ; Console.WriteLine($"val10 type: { val10.GetType() }");
            int val11 = 0          ; Console.WriteLine($"val11 type: {val11.GetType()}");
            double val12 = 0.0     ; Console.WriteLine($"val12 type: { val12.GetType() }");
            float val13 = 0.0F     ; Console.WriteLine($"val13 type: { val13.GetType() }");
            char val14 = '가'      ; Console.WriteLine($"val14 type: { val14.GetType() }");
            string val15 = "문자열"; Console.WriteLine($"val15 type: { val15.GetType() }");
            float val16 = val13   ; Console.WriteLine($"val16 type: { val16.GetType() }");

        }
    }
}