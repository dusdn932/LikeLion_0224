using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //조건문 if문과 가지치기
            /*int score = 85;
            if(score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else
            {
                Console.WriteLine("90점 미만");
            }
            Console.WriteLine("이프문이 끝났습니다.");*/

            //else문
            /*int number = 10;
            if (number > 15)
            {
                Console.WriteLine("15보다 큽니다");
            }
            else
            {
                Console.WriteLine("15보다 작거나 같습니다");
            }
            string GameID = "멋사검존";


            if (GameID == "멋사검존")
            {
                Console.WriteLine("아이디가 일치합니다.");
            }
            else
            {
                Console.WriteLine("아이디가 일치하지 않습니다.");
            }*/
            //else if문
            /*int score = int.Parse(Console.ReadLine());
            if(score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if(score >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if(score >= 70)
            {
                Console.WriteLine("C학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }*/

            //미니과제
            //가지고있는 소지금을 입력하세요
            //0~100 무한의 대검 +1
            //101~200 카타나 +2
            //201~300 진은검 +3
            //301~400 집판검 +4
            //401~500 엑스칼리버 +5
            //500~600 유령검 +6
            /*Console.WriteLine("캐릭터명을 적으시오 : ");
            string name = Console.ReadLine();
            Console.WriteLine("소지금을 적으시오 : ");
            int money = int.Parse(Console.ReadLine());
            int stt = 100;
            string weppon;
            if (money <=0 && money <= 100)
            {
                Console.WriteLine(weppon = "무한의 대검");
                stt = stt + 1;
            }
            else if (money <= 200)
            {
                Console.WriteLine(weppon = "카타나");
                stt = stt + 2;
            }
            else if (money <= 300)
            {
                Console.WriteLine(weppon = "진은검");
                stt = stt + 3;
            }
            else if (money <= 400)
            {
                Console.WriteLine(weppon = "집판검");
                stt = stt + 4;
            }
            else if (money <= 500)
            {
                Console.WriteLine(weppon = "엑스칼리버");
                stt = stt + 5;
            }
            else if (money <= 600)
            {
                Console.WriteLine(weppon = "유령검");
                stt = stt + 6;
            }
            else
            {
                Console.WriteLine(weppon = "전설의 검");
                stt = stt + 7;
            }
                Console.WriteLine("캐릭터명 : " + name + "\n" +weppon+ "\n" + "공격력 : " + stt);*/
            

        }
    }
}
