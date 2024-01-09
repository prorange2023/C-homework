using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Project
{
    internal class Program
    {

        // 앞서 어딘가에 메모한 fnc delegate는 함수랑 동치 가능 기억회상편 까먹지 말자
        public class Calculator
        {
            Func<double, double, double> calc;
            double left;
            double right;

            public double Add(double x, double y)
            {
                return x + y;
            }

            public double Minus(double x, double y)
            {
                return x - y;
            }
            public void SetCommand(double left, char oper, double right)
            {
                // 계산금지
                switch (oper)
                {
                    case '+':
                        calc = Add;
                        break;
                    case '-':
                        calc = Minus;
                        break;
                }
                this.left = left;
                this.right = right;
            }

            public double Equal()
            {
                // 조건문 쓰기 금지
                return calc(left, right);
            }
        }

        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.SetCommand(2.5, '+', 3.2);
            double result = cal.Equal();
            Console.WriteLine(result);
            // 결과가 5.7이 나오도록 구현

        }
    }
}