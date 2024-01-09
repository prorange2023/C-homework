namespace _20240105_04

{
    internal class Program
    {
        public class Player
        {
            public event Action OnChangeHp;

            public int hp
            {
                get { return hp; }
                set { if (OnChangeHp != null) OnChangeHp(); }
            }




        }

        public class UI
        {
            public void HpBar()// <= 이 변수 때문인건 알았는데, 이걸 어떻게 해결해야하는가? 없애고 밑에서 변수 빼면 되긴 하는데 그럼 UI에 반영할 수가 없음...
            {
                Console.WriteLine($"player의 HP가 player.hp로 변화했습니다.");
            }
        }


        static void Main()
        {
            Player player = new Player();
            UI ui = new UI();

            player.OnChangeHp += ui.HpBar;

            player.hp = 30;
            player.hp = 100;
            player.hp = 150;
            player.hp = 120;
            player.hp = 90;
        }
    }
}

