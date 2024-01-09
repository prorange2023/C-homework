namespace _20240105_03
{
    internal class Program
    {
        public class Player
        {
            public int Hp { get; private set; }
        }
        static void Main()
        {
            Player player = new Player();
            int playerHp = player.Hp;
            // player.Hp = 100; <= 이게 요구하신 읽기 전용이 맞는지 확인
        }
    }
}
