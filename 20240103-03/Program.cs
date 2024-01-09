namespace _20240103_03
{
    internal class Program
    {
        public class Player
        {
            public void Jump()
            {
                Console.WriteLine("플레어가 점프함");
            }

            public void Dash()
            {
                Console.WriteLine("플레이어가 대시함");
            }
        }

        public class  Button
        {
            public Action OnClick;

            public void Click()
            {
                if (OnClick != null)
                    OnClick();
            }

        }
        static void Main(string[] args)
        {
            Player player = new Player();

            Button jumpButton = new Button();

            jumpButton.OnClick = player.Jump;

            jumpButton.Click();

            Button dashButton = new Button();

            dashButton.OnClick = player.Dash;

            dashButton.Click();
        }
    }
}
