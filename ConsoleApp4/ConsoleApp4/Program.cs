using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   //과제1 세정수의 최대값 구하기
               int a, b, c;
               int max = 0;
               Console.Write("a값을 입력하시오");
               a = int.Parse(Console.ReadLine());
               Console.Write("b값을 입력하시오");
               b = int.Parse(Console.ReadLine());
               Console.Write("c값을 입력하시오");
               c = int.Parse(Console.ReadLine());
               if (a < b)
               {
                   if(b < c)
                   {
                       max = c;
                   }
                   else{
                       max = b;
                   }
               }
               else
               {
                   if (a < c)
                   {
                       max = c;
                   }
                   else
                   {
                       max = a;
                   }
               }
               Console.WriteLine("최대값 : " + max);

               //과제2 점수에 따른 학점 평가
               int score;
               Console.Write("점수을 입력하시오 : ");
               score = int.Parse(Console.ReadLine());
               if(score <=100 && score >= 90)
               {
                   Console.WriteLine("A학점");
               }
               else if(score <90 && score >= 80)
               {
                   Console.WriteLine("B학점");
               }
               else if (score < 80 && score >= 70)
               {
                   Console.WriteLine("C학점");
               }
               else if (score < 70 && score >= 60)
               {
                   Console.WriteLine("D학점");
               }
               else if (score < 60 && score >= 0)
               {
                   Console.WriteLine("F학점");
               }
               else
               {
                   Console.WriteLine("잘못입력하셨습니다.");
               }
               //과제3 간단한 사칙연산 계산기
               int x, y, result=0;
               char op; 

               Console.Write("a값을 입력하시오");
               x = int.Parse(Console.ReadLine());
               Console.Write("부호를 입력하시오");
               op = char.Parse(Console.ReadLine());
               Console.Write("b값을 입력하시오");
               y = int.Parse(Console.ReadLine());
               if (op == '+')
               {
                   result = x + y;
               }
               else if (op == '-')
               {
                   result = x - y;
               }
               else if (op == '*')
               {
                   result = x * y;
               }
               else if (op == '/')
               {
                   result = x / y;
               }
               Console.WriteLine(result);*/

            //문자열 공백으로 배열만들어 계산기만드는 수정버전
            /*Console.Write("Enter two numbers: ");
            string input = Console.ReadLine();    // 문자열 받기
            double result1 = 0;
            string[] numbers = input.Split(' ');  // 문자열을 공백으로 구분하여 배열로 만들기
            int num1 = int.Parse(numbers[0]);     // 첫 번째 값을 정수로 변환하여 저장
            char op1 = char.Parse(numbers[1]);
            int num2 = int.Parse(numbers[2]);     // 두 번째 값을 정수로 변환하여 저장
            if(op1 == '+')
            {
                result1 = num1 + num2;
            }
            else if(op1 == '-')
            {
                result1 = num1 - num2;
            }
            else if (op1 == '*')
            {
                result1 = num1 * num2;
            }
            else if (op1 == '/')
            {
                result1 = num1 / num2;
            }
            Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, result1);*/
        }
    }
}
