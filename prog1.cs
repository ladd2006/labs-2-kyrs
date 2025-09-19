using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public  class Product
        {
            protected string Name;

            public Product(string Name)
            {
                Console.Write("Введите названия изделия: ");
                this.Name = Console.ReadLine();
            }
            public void Print()
            {
                Console.WriteLine(Name);
            }

        }
        public class Part : Product
        {
            public int count;
            public Part(int count, string Name) : base(Name)
            {
                this.count = count;
            }
            public void Print1()
            {
                Console.WriteLine($"{Name} этого изделия имеется {count} штук");
            }

        }
        public class Mechanism : Part
        {
            public int countParts;
            public Mechanism(int countParts, int count, string Name) : base(count, Name)
            {
                this.countParts = countParts;
            }
            public  void Print2()
            {
                Console.WriteLine($"В этом механизме {Name} хранится {count}  и {countParts} деталей ");
            }
        }
        public class Knot : Mechanism
        {
            public int countMecha;
            public Knot(int countParts, int count, string Name, int countMecha) : base(count, countParts, Name)
            {
                this.countMecha = countMecha;
            }
            public void Print3()
            {
                Console.WriteLine($"Изделие {Name} состоит из {countMecha} узлов или из {countParts} механизмов или из {count} деталей");
            }

        }

        static void Main(string[] args)
        {

            Knot p1 = new Knot(30, 120, " ", 10);
            p1.Print3();
            Mechanism p2 = new Mechanism(30, 100, " ");
            p2.Print2();

        }
    }
}
