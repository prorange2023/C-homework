namespace _20240104___01
{
    internal class Program
    {

        // callback 간단 응용
        public class Player
        {
            public event Action OnGetCoin;

            public void GetCoin()
            {
                Console.WriteLine("플레이어가 코인을 얻음");
                if (OnGetCoin != null)
                    OnGetCoin();
            }
        }

        public class UI
        {
            public void UpdateUI()
            {
                Console.WriteLine("플레이어가 코인을 얻어 UI갱신");
            }
        }

        public class SFX
        {
            public void CoinSound()
            {
                Console.WriteLine("플레이어가 코인을 얻어 동전소리 실행");

            }
        }

        public class VFX
        {
            public void CoinEffect()
            {
                Console.WriteLine("플레이어가 코인을 얻어 황금코인 이펙트 실행");
            }
        }
        

        static void Main()
        {
            Player player = new Player();
            UI ui = new UI();
            SFX sfx = new SFX();
            VFX vfx = new VFX();

            player.OnGetCoin += ui.UpdateUI;
            player.OnGetCoin += sfx.CoinSound;
            player.OnGetCoin += vfx.CoinEffect;


            player.GetCoin();
        }
    }
}
