namespace _20240102___02
{
    internal class Program
    {
        // IComparable 인터페이스 응용

        //     A++) IComparable 인터페이스(구글링, MSDN, StackOverflow)

        //     Item class를 IComparable 붙여서

        //    Item[] inventory = new Item[5]; 배열이 있으면

        //    이름순으로 정렬시키기 구현 해보기
        

        class Item : IComparable
        {
            public string name;
            public int ea;

            public int CompareTo(object obj)
            {
                Item item = (Item)obj;
                return this.name.CompareTo(item.name);
            }

            public override string ToString()
            {
                return string.Format($"[{name},{ea}]");
            }
        }


        

        static void Main(string[] args)
        {
            List<Item> aList = new List<Item>();
            Item Temp = new Item();
            Temp.name = "potion";
            Temp.ea = 20;
            aList.Add(Temp);

            Temp = new Item();
            Temp.name = "bow";
            Temp.ea = 1;
            aList.Add(Temp);

            Temp = new Item();
            Temp.name = "arrow";
            Temp.ea = 1;
            aList.Add(Temp);

            Temp = new Item();
            Temp.name = "meet";
            Temp.ea = 20;
            aList.Add(Temp);

            Temp = new Item();
            Temp.name = "waterbottle";
            Temp.ea = 2;
            aList.Add(Temp);


            foreach (var vTemp in aList)
            {
                Console.WriteLine(vTemp);
            }

            Console.WriteLine();
            aList.Sort();   // 배열 정렬 구문 <= 위에 지정한 규칙대로 정렬하라는 명령 구문 맞나
            foreach (var vTemp in aList)
            {
                Console.WriteLine(vTemp);
            }

            
        }
    }
}
