using System;

namespace OperatorOverloadingMethods
{
    class Program
    {
        private int x;
        private int y;


        static void Main(string[] args)
        {
            var p1 = new Program(2, 3);
            var p2 = new Program(3, 3);

            Console.WriteLine("p1: " + p1);
            Console.WriteLine("p2: " + p2);

            Console.WriteLine();

            Console.WriteLine("p1 + p2: " + (p1 + p2));
            Console.WriteLine("p1 - p2: " + (p1 - p2));
            Console.WriteLine("p1 * p2: " + (p1 * p2));
            Console.WriteLine("p1 / p2: " + (p1 / p2));
            Console.WriteLine("p1 % p2: " + (p1 % p2));

            Console.WriteLine();

            Console.WriteLine("p1 == p2: " + (p1 == p2));
            Console.WriteLine("p1 != p2: " + (p1 != p2));
            Console.WriteLine("p1 >= p2: " + (p1 >= p2));
            Console.WriteLine("p1 <= p2: " + (p1 <= p2));
            Console.WriteLine("p1 > p2: " + (p1 > p2));
            Console.WriteLine("p1 < p2: " + (p1 < p2));
        }

        public Program()
        {
        }

        public Program(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }

        public static Program operator +(Program p1, Program p2)
        {
            return new()
            {
                x = p1.x + p2.x,
                y = p1.y + p2.y
            };
        }

        public static Program operator -(Program p1, Program p2)
        {
            return new()
            {
                x = p1.x - p2.x,
                y = p1.y - p2.y
            };
        }

        public static Program operator *(Program p1, Program p2)
        {
            return new()
            {
                x = p1.x * p2.x,
                y = p1.y * p2.y
            };
        }

        public static Program operator /(Program p1, Program p2)
        {
            return new()
            {
                x = p1.x / p2.x,
                y = p1.y / p2.y
            };
        }

        public static Program operator %(Program p1, Program p2)
        {
            return new()
            {
                x = p1.x % p2.x,
                y = p1.y % p2.y
            };
        }

        public static bool operator ==(Program p1, Program p2)
        {
            return p1?.x == p2?.x && p1?.y == p2?.y;
        }

        public static bool operator !=(Program p1, Program p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Program p1, Program p2)
        {
            if (p1 == null)
                return false;

            if (p2 == null)
                return false;

            bool flag1 = p1.x > p2.x && p1.y == p2.y;
            bool flag2 = p1.x == p2.x && p1.y > p2.y;
            bool flag3 = p1.x > p2.x && p1.y > p2.y;

            return flag1 || flag2 || flag3;
        }

        public static bool operator <(Program p1, Program p2)
        {
            if (p1 == null)
                return false;

            if (p2 == null)
                return false;

            bool flag1 = p1.x < p2.x && p1.y == p2.y;
            bool flag2 = p1.x == p2.x && p1.y < p2.y;
            bool flag3 = p1.x < p2.x && p1.y < p2.y;

            return flag1 || flag2 || flag3;
        }

        public static bool operator >=(Program p1, Program p2)
        {
            if (p1 == null)
                return false;

            if (p2 == null)
                return false;

            bool flag1 = p1.x >= p2.x && p1.y == p2.y;
            bool flag2 = p1.x == p2.x && p1.y >= p2.y;
            bool flag3 = p1.x >= p2.x && p1.y >= p2.y;

            return flag1 || flag2 || flag3;
        }

        public static bool operator <=(Program p1, Program p2)
        {
            if (p1 == null)
                return false;

            if (p2 == null)
                return false;

            bool flag1 = p1.x <= p2.x && p1.y == p2.y;
            bool flag2 = p1.x == p2.x && p1.y <= p2.y;
            bool flag3 = p1.x <= p2.x && p1.y <= p2.y;

            return flag1 || flag2 || flag3;
        }
    }
}
