using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_6_5
{
    class CollectionType
    {
        LinkedList<CollectionType> list = new LinkedList<CollectionType>();
        int year { get; set; }
        string name { get; set; }
        int diameter { get; set; }
        int frequency { get; set; }
        public CollectionType() { }

        public CollectionType(int year, string name, int diameter, int frequency)
        {
            this.year = year;
            this.name = name;
            this.diameter = diameter;
            this.frequency = frequency;
        }
        public void Add(CollectionType[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                list.AddLast(c[i]);
            }
        }
        public void Output()
        {
            Console.WriteLine("Рiк | Науковий керiвник | Дiаметр антени (м) | Робоча частота (Мгц)");

            foreach (CollectionType s in list)
            {
                Console.WriteLine($"{s.year}, {s.name}, {s.diameter}, {s.frequency}");
            }
        }
        public void Select()
        {
            Console.WriteLine("\nSelect 1:");
            var where = list.Where(h => (h.diameter >= 100 && h.frequency > 1450));
            Console.WriteLine("Рiк | Науковий керiвник | Дiаметр антени (м) | Робоча частота (Мгц)");
            foreach (var s in where)
            {
                Console.WriteLine($"{s.year}, {s.name}, {s.diameter}, {s.frequency}");
            }

            Console.WriteLine("\nSelect 2:");
            var min = list.Min(h => h.frequency);
            Console.WriteLine($"{min}");

            Console.WriteLine("\nSelect 3:");
            var max = list.Max(h => h.frequency);
            Console.WriteLine($"{max}");

            Console.WriteLine("\nSelect 4:");
            var count = list.Count();
            Console.WriteLine($"{count}");

            Console.WriteLine("\nSelect 5:");
            var order = list.OrderByDescending(h => h.year);
            Console.WriteLine("Рiк | Науковий керiвник | Дiаметр антени (м) | Робоча частота (Мгц)");
            foreach (var s in order)
            {
                Console.WriteLine($"{s.year}, {s.name}, {s.diameter}, {s.frequency}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CollectionType ct = new CollectionType();

            CollectionType[] collections = {
            new CollectionType(1960, "Дрейк", 26, 1420),
            new CollectionType(1970, "Троїцкий", 14, 1875),
            new CollectionType(1978, "Хоровiц", 300, 1665)
        };

            ct.Add(collections);
            ct.Output();
            ct.Select();
        }
    }
}
