namespace _20240103___02
{
    internal class Program
    {
        public class Calculator
        {
            // delegate 기초 


            double left;
            double right;

            Func<double, double, double> calc;

            // Func delegate 는 함수랑 동치 가능 이거 알아두면 편하긴 했음

            public double Add(double left, double right) { return left + right; }
            public double Minus(double left, double right) { return left - right; }

            public double Multi(double left, double right) { return left * right; }

            public double Divide(double left, double right) { return left / right; }
        

            public void SetCommand(double left, char oper, double right)
            {

                
                switch(oper)
                {
                    case '+':
                        calc = Add;
                        break;
                    case '-':
                        calc = Minus;
                        break;
                    case '*':
                        calc = Multi;
                        break;
                    case '/':
                        calc = Divide;
                        break;

                }
                this.left = left;
                this.right = right;
            }

            public double Equal()
            {
                return calc(this.left, this.right);
            }
        }


        static void Main()
        {


            Calculator cal = new Calculator();
            cal.SetCommand(2.5, '+', 3.2);
            double result = cal.Equal();
            Console.WriteLine(result);
            //결과가 5.7 나오게 구현
        }
    }
}
