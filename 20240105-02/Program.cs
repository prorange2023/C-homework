namespace _20240105_02
{
    internal class Program
    {
        // ref(참조) = 얕은복사 개념 익히기
        public static void Swap<Temp>(ref Temp left, ref Temp right)
        {
            Temp exam = left;
            left = right;
            right = exam;
        }
        public static void Main()
        {
            float left = 3.5f;
            float right = 4.0f;

            Swap<float>(ref left,ref right);

            Console.WriteLine($"left 는 {left} 입니다.");
            Console.WriteLine($"right 는 {right} 입니다.");
        }
    }
}
