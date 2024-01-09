using System;
using System.Collections.Generic;
namespace _20200821_002_IComparable2
{
    class Program
    {

        //     A++) IComparable 인터페이스(구글링, MSDN, StackOverflow)

        //     Item class를 IComparable 붙여서

        //    Item[] inventory = new Item[5]; 배열이 있으면

        //    이름순으로 정렬시키기 구현 해보기


        class Item : IComparable
        {
            public string Name { get; set; }
            public int Ea { get; set; }

            public Item(string name, int ea)
            {
                Name = name;
                Ea = ea;
            }

            public int CompareTo(object obj)
            {
                return Name.CompareTo(((Item)obj).Name);
            }

            public override string ToString()
            {
                return string.Format("{0}, {1}", Name, Ea);
            }
        }
        static void Main(string[] args)
        {
            

            Item[] inventory =
            {
               new Item("활", 2),
               new Item("화살", 250),
               new Item("포션", 20),
               new Item("육포", 10),
               new Item("물병", 2)
            };

            Array.Sort(inventory);

            Console.WriteLine(inventory);





        }
    }

    
}