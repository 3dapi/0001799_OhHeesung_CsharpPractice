

using System.Data;

/**
 *
 *
 *
 *
 *이 프로그램은 식별자, 주석 연습니다.
 *////<summary>
   ///
   /// 
   ///</summary>
class Program
{
    static void Main(string[] args)
    {
        // 키워드, 식별자 연습.
        //string name = "오희성";
        //string id = "9001794";
        //string subject = "객체지향C#";

        //Console.WriteLine($"이력서");
        //Console.WriteLine($"이름: {name}");
        //Console.WriteLine($"학번: {id}");
        //Console.WriteLine($"과목: {subject}");

        // 연산 연습
        //Console.WriteLine(10 + 2000);
        //Console.WriteLine(10 + "2000");
        //Console.WriteLine(Int32.Parse("10") + 2000);
        //Console.WriteLine("10" + "2000");

        // 연산 연습
        //Console.WriteLine((12345 % 10) / 1);
        //Console.WriteLine((12345 % 100) / 10);
        //Console.WriteLine((12345 % 1000) / 100);
        //Console.WriteLine((12345 % 10000) / 1000);
        //Console.WriteLine((12345 % 100000) / 10000);

        // x % y = x - (x / y) * y
        //Console.WriteLine(4 % 3);
        //Console.WriteLine(4 % -3);      //  4 - ( 4/-3) * (-3)
        //Console.WriteLine(-4 % 3);      //  4 - (-4/3) * (3)
        //Console.WriteLine(-4 % -3);     // -4 - (-4/-3) *(-3)

        //Console.WriteLine(12345.0 / 1000.0);

        //Console.WriteLine(1/ 2);
        //Console.WriteLine(1.0 / 2.0);

        //Console.WriteLine(5.0 % 2.2);
        //Console.WriteLine(0.6 /1.0);

        // 문자형
        //Console.WriteLine('똚');

        // 문자열
        //Console.WriteLine("이력서\n\t\\이름: \"오희성\"");
        //Console.WriteLine("이력서" + "\n\t\\이름: \"오희성\"");

        //인덱스는 0부터
        //Console.WriteLine("안녕하세요"[0]);
        //Console.WriteLine("안녕하세요"[1]);
        //Console.WriteLine("안녕하세요"[2]);
        //Console.WriteLine("안녕하세요"[4]);
        //Console.WriteLine("안녕하세요"[1004]);

        //Console.WriteLine("한" + "글");

        //Console.WriteLine("난" + 0XAC00);

        //boolean
        //Console.WriteLine(true);    
        //Console.WriteLine(false);

        // 변수
        int       idNumber = 1000000000;
        long      gameMoney = 100000000000000000;
        double    score   ;
        char      character;
        string    message  ;

        idNumber = 15;
        gameMoney = 200;

        //Console.WriteLine(idNumber % gameMoney);

        //int a = 2147483640;
        //int b = 52273;
        //Console.WriteLine(a+b);
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);
        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);
    }
}

// 기획문서의 스펙을 적는다.
class GameScene
{
    //// 생성
    //Create();
    //// 초기화
    //Init();
    //// 갱신
    //Update();

    //// 렌더링
    //Render();

    //// 파괴
    //Destroy();
}


