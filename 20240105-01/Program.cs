

namespace _20240105_01
{
    internal static class Program
    {

        

        public static float CheckOdd(this float num)
        {
            
            if ((num/2) == 0)
            {
                Console.WriteLine($"{num}은 짝수입니다.");
            }
            else
            {
                Console.WriteLine($"{num}은 홀수입니다.");
            }
            return num;
        }


        public static void Main()
        {

            float num1 = 3;
            float checkodd = CheckOdd(num1);
            float chsck2 = num1.CheckOdd();
        }
    }
}
