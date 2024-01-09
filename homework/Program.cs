namespace homework
{
    internal class Program
    {
        // 인터페이스, IComparable 훈련
        //플레이어 : 물체를 여는 기능, 들어가는 기능
        //        상자, 문, 마을
        //        문, 마을 : 들어갈 수 있어야 함
        //문 들어갔을 때 : 건물안으로 들어간다.
        //마을 들어갔을 때 : 마을 맵을 진입한다.
        //상자, 문 : 열수 있어야 함
        //상자를 열면 : 아이템 나오게
        //문을 열면 : 진입할 수 있도록 설명한다.

        //탑승물 : 탈수 있어야 한다.열어야지 탈수 있다.

        //     A++) IComparable 인터페이스(구글링, MSDN, StackOverflow)

        //     Item class를 IComparable 붙여서

        //    Item[] inventory = new Item[5]; 배열이 있으면

        //    이름순으로 정렬시키기 구현 해보기
        public interface IOpenable
        {
            void Open();
        }

        public interface IEnterable
        {
            void Enter();
        }

        public interface IBoardable
        {
            void Board();
        }

        public class Player
        {
            public void Open(IOpenable openable)
            {
                Console.WriteLine($"플레이어가 {openable}을 열기를 시도합니다");
                openable.Open();
            }
            public void Enter(IEnterable enterable)
            {
                Console.WriteLine($"플레이어가 {enterable}로 진입을 시도합니다");
                enterable.Enter();
            }
           
        }

        public class Box : IOpenable
        {
            public void Open() 
            {
                Console.WriteLine("상자가 열립니다.");
                Console.WriteLine("포션을 얻었습니다.");
            }
        }

        public class Door : IOpenable, IEnterable
        {
            public void Open()
            {
                Console.WriteLine("문을 열었습니다. 이제 진입이 가능합니다.");                
            }

            public void Enter()
            {
                Console.WriteLine("플레이어가 건물 안으로 진입합니다.");
            }
        }
        public class Town : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("마을 안으로 진입합니다.");
            }
        }

        public class Vehicle : IOpenable, IEnterable
        {
            private int state = 0;


            public void Open()
            {

                Console.WriteLine("탑승물의 문을 엽니다.");
                this.state = 1;
            }

            public void Enter()
            {
                
                switch(this.state)
                {
                    case 0:
                        Console.WriteLine("문이 닫혀있습니다. 탑승하지 못했습니다.");
                        break;
                    case 1:
                        Console.WriteLine("탑승에 성공했습니다.");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Vehicle vehicle = new Vehicle();
            Door door = new Door();
            Box box = new Box();
            Town town = new Town();

            player.Open(door);
            player.Enter(town);

            player.Enter(vehicle);

        }
    }
}
