namespace _20240104___02
{
    internal class Program
    {
        // Compare 함수 만들기, 자료형맞추기, readline활용
        public static int Compare(int x, int y)
        {
            return (x.CompareTo(y));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            string input = Console.ReadLine();

            int value1 = int.Parse(input);

            Console.WriteLine("숫자를 다시한번 입력하세요");
            int value2 = int.Parse(Console.ReadLine());

            int result = Compare(value1, value2);

            Console.WriteLine($"{value1} / {value2} = {value1 / value2} 입니다.");

            //switch(result)
            //{
            //    case 0: 
            //        Console.WriteLine($"{value1} / { value2} = {value1 / value2} 입니다.");
            //        break;
            //        case 1: Console.WriteLine($"{value1} / {value2} = {value1 / value2} 입니다.");
            //        break;
            //        case 
            //}


        }


    }
}
