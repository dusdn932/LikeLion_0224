using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //이진수 다루기(이진수와 정수 서로변경)
            /*Console.Write("2진수를 입력하세요: ");
            string binaryInput = Console.ReadLine();
            int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환
            // 정수를 이진수로 변환
            string binaryOutput = Convert.ToString(decimalValue, 2); // 10진수 -> 2진수 변환
            Console.WriteLine($"입력한 이진수: {binaryInput}");
            Console.WriteLine($"10진수로 변환: {decimalValue}");
            Console.WriteLine($"다시 이진수로 변환: {binaryOutput}");*/


            // var 키워드로 암시적으로 형식화된 로컬 변수 만들기
            /*var name = "Alice";//문자열로 추론
            var age = 25;//정수로 추론
            var isSudent = true;//논리값으로 추론
            Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isSudent}");*/

            //변수의 기본값을 default 키워드로 설정하기    
            /*int defaultInt = default; // 기본값: 0
            string defaultString = default; // 기본값: null
            bool defaultBool = default; // 기본값: false
            Console.WriteLine($"정수 기본값: {defaultInt}"); // 출력: 0
            Console.WriteLine($"문자열 기본값: {defaultString}"); // 출력: (null)
            Console.WriteLine($"논리값 기본값: {defaultBool}"); // 출력: False*/

        }
    }
}
