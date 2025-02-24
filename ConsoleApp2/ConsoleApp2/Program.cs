using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //연산자
            /*int a = 5, b=3;
            int sum = a + b;
            bool isEqual = (a == b);
            Console.WriteLine($"합 : {sum}");// 출력8
            Console.WriteLine($"a와b가 같은가? {isEqual}");//출력 False
            sum = a + b;
            Console.WriteLine($"합 : {sum}");// 더하기
            sum = a - b;
            Console.WriteLine($"차 : {sum}");// 뺴기
            sum = a * b;
            Console.WriteLine($"곱 : {sum}");// 곱하기
            sum = a / b;
            Console.WriteLine($"나누기 : {sum}");// 나누기
            sum = a % b;
            Console.WriteLine($"나머지 : {sum}");// 나머지
            
            bool isEqual = true;
            int a = 5;
            int b = 6;

            isEqual = (a == b);
            Console.WriteLine("같은가?" + isEqual);*/

            //단항 연산자
            /*int number = 5;
            Console.WriteLine(+number); // 양수 출력: 5
            Console.WriteLine(-number); // 음수 출력: -5
            bool flag = true;
            Console.WriteLine(!flag); // 논리 부정: False
            int num = 10;
            int result = ~num;
            Console.WriteLine($"원래값  : {num}");
            Console.WriteLine($"비트반전 : {result}");*/

            //변환 연산자: ( ) 기호로 데이터 형식 변환하기 - 캐스팅
            /*double pi = 3.14;
            int integerPi = (int)pi; // 실수를 정수로 변환
            Console.WriteLine(integerPi); // 출력: 3*/

            /*int ikor = 90;
            int ieng = 75;
            int imath = 58;
            int sum = 0;
            float average = 0.0f;
            sum = ikor + ieng + imath;
            average = (float)sum / 3; // 평균 int합을 float로 변환
            Console.WriteLine($"합 : {sum}");
            Console.WriteLine($"평균 : {average}");*/


            //산술 연산자
            /*int a = 10, b = 3;
            Console.WriteLine(a + b); // 덧셈: 13
            Console.WriteLine(a - b); // 뺄셈: 7
            Console.WriteLine(a * b); // 곱셈: 30
            Console.WriteLine(a / b); // 나눗셈: 3
            Console.WriteLine(a % b); // 나머지: 1*/

            //문자열 연결 연산자
            /*string firstName = "ALice";
            string lastName = "Smith";
            Console.WriteLine(firstName + " " + lastName);*/

            //할당 연산자
            /*int a = 10;
            a += 5; // a = a + 5
            Console.WriteLine(a);
            a -= 5; // a = a - 5
            Console.WriteLine(a);
            a *= 5; // a = a * 5
            Console.WriteLine(a);
            a /= 5; // a = a / 5
            Console.WriteLine(a);
            a %= 5; // a = a % 5
            Console.WriteLine(a);*/

            /*//미니과제
            //과제1 : 세개 과목 평균
            Console.Write("국어점수 : ");
            int ikor = int.Parse(Console.ReadLine());
            Console.Write("영어점수 : ");
            int ieng = int.Parse(Console.ReadLine());
            Console.Write("수학점수 : ");
            int imath = int.Parse(Console.ReadLine());
            int sum = 0;
            float average = 0.0f;
            sum = ikor + ieng + imath;
            average = (float)sum / 3; // 평균 int합을 float로 변환
            string average2 = average.ToString("F2");
            Console.WriteLine($"합 : {sum}");
            Console.WriteLine($"평균 : {average2}");
            //과제2 : 비트 반전(~) 연산자 활용

            Console.Write("정수를 입력하시오 : ");
            int i = int.Parse(Console.ReadLine());
            int m = ~i;
            Console.WriteLine($"반전 비트값 : {m}");*/



            //증감연산자
            //전위 ++b 후위 b++
            /*int b = 3;
            b++; // 후위 증가
            Console.WriteLine(b++); //출력 : 3
            Console.WriteLine(b); //출력 : 4
            --b; // 후위 감소
            Console.WriteLine(b--); // 출력 : 3
            Console.WriteLine(b); // 출력 : 2*/

            //관계형 연산자
            //두값을 비교하여 관계를 평가한다
            //== 같다 != 같지않다 <, >, <=, >=
            /*int x = 5, y = 10;
            Console.WriteLine(x == y); //두값이같냐
            Console.WriteLine(x != y);//두값이 틀리냐
            Console.WriteLine(x < y);//y값이 더 크냐
            Console.WriteLine(x > y);//x값이 더 크냐
            Console.WriteLine(x <= y); //y값이 크거나 같냐
            Console.WriteLine(x >= y);//x값이 크거나 같냐*/

            //논리연산자
            /*bool a = true, b = false;
            Console.WriteLine(a && b); // AND: False
            Console.WriteLine(a || b); // OR: True
            Console.WriteLine(!a); // NOT: False*/

            /* //비트 연산자
             int x = 5; // 0101
             int y = 3; // 0011
             Console.WriteLine(x & y); // AND: 1 (0001)
             Console.WriteLine(x | y); // OR: 7 (0111)
             Console.WriteLine(x ^ y); // XOR: 6 (0110)
             Console.WriteLine(~x); // NOT: -6

             //시프트 연산자
             int value = 4; // 0100
             Console.WriteLine(value << 1); // 왼쪽 이동: 8 (1000)
             Console.WriteLine(value >> 1); // 오른쪽 이동: 2 (0010)*/

            /*//기타 연산자
            int a = 10, b = 20;
            int max = (a > b) ? a : b; // 삼항 연산자
                                       //a가 b보다 크냐 비교 후에
                                       // true일때 a(10)값 출력 false일때 b(20)출력
                                       //( 비교 ) ? 참 : 거짓;
            Console.WriteLine(max); // 출력: 20

            int key = 1;
            string str = 
            str = (key == 1) ? "문이 열렸습니다" :"문을 열지못했습니다.";
            Console.WriteLine(str);*/
            //연산자 우선순위
            /*int result = 10 + 2 * 5; // 곱셈이 덧셈보다 우선
            Console.WriteLine(result); // 출력: 20
            int adjustedResult = (10 + 2) * 5; // 괄호로 우선순위 변경
            Console.WriteLine(adjustedResult); // 출력: 60*/

        }
    }
}
