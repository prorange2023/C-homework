namespace _20240105_05
{
    internal class Program
    {
        public class Player
        {
            int HP = 100;
            public event Action<int> OnChangeHp;

            public int hp
            {
                get 
                { 
                    return hp; 
                }
                set 
                { 
                    hp = value; if (OnChangeHp != null) OnChangeHp(hp);
                }
            }
            public void TakeDamage(int damage)
            {
                hp-=(int)damage;
                Console.WriteLine($"플레이어가 데미지를 받아 {hp} 체력이 되었습니다.");
                
            }

            public void Heal(int damage)
            {
                hp+=(int)damage;
                Console.WriteLine($"플레이어가 힐을 받아 {hp} 체력이 되었습니다.");
            }
        }

        public class UI
        {
            public void HpBar(int hp)
            {
                Console.WriteLine($"player의 HP가 {hp}로 변화했습니다.");
            }
        }

        static void Main()
        {
            Player player = new Player();
            UI ui = new UI();

            player.OnChangeHp += ui.HpBar;

            player.TakeDamage(10);
            player.hp = 30;
            player.hp = 100;
            player.hp = 150;
            player.hp = 120;
            player.hp = 90;
        }
    }
}
