//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Diagnostics;
using System.Text;
namespace MySystem
{
    class Program
    {
        //static void Main(string[] args)//문자열 예제
        //{
        //    //문자열 변수
        //    string s1 = "C#";
        //    string s2 = "Programming";
        //    //문자 변수
        //    char c1 = 'A';
        //    char c2 = 'B';

        //    string s3 = s1 + " " + s2;
        //    Console.WriteLine("String: {0}", s3);

        //    string s3substring = s3.Substring(1,5);
        //    Console.WriteLine("Substring: {0}",s3substring);
        //}
        
        //문자열,문자,문자배열.
        //static void Main(string[] args)
        //{
        //    string s = "C# Studies";

        //    //문자열 배열 인덱스로 한문자 엑세스
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        Console.WriteLine("{0}: {1}", i, s[i]);
        //    }

        //    //문자열을 문자배열로 변환
        //    string str = "hello";
        //    char[] charArray = str.ToCharArray();

        //    for(int i = 0; i < charArray.Length; i++)
        //    {
        //        Console.WriteLine(charArray);
        //    }

        //    char[] charArray2 = { 'A', 'B', 'C', 'D' };
        //    s = new string(charArray2);

        //    Console.WriteLine(s);

        //    char c1 = 'A';
        //    char c2 = (char)(c1 + 3);
        //    Console.WriteLine(c2);  
        //}
        
        static void Main(string[] args)//stringbuilder 클래스
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i <= 26; i++)
            {
                sb.Append(i.ToString());
                sb.Append(System.Environment.NewLine);
            }
            string s = sb.ToString();

            Console.WriteLine(s);
        }

    }
}