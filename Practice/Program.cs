using System;
using static System.Net.Mime.MediaTypeNames;

namespace Practice
{
    internal class Program
    {

        public static int FindKeyIndex(string text, char key)
        {
            
            char[] array = text.ToCharArray();
            int result = Array.IndexOf(array, key);
            return result;

        }





        public static void Main()
        {
            Console.WriteLine("자료 문장을 입력하세요.");
            string text = Console.ReadLine();

            Console.WriteLine("검색할 문자를 입력하세요.");
            char key = char.Parse(Console.ReadLine());

            int result = FindKeyIndex(text, key);

            Console.WriteLine($"{result}");
        }
    }
}

