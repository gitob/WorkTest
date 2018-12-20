using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTest
{
    public class Tmpr
    {
        public int F1 { get; set; }
        public int F2 { get; set; }
        public Func<int, int, bool> Fuc { get; set; }
        public Program.MethodNameDelegate Del { get; set; }
        public string Str { get; set; }
    }

    public class Program
    {
        public delegate void MethodNameDelegate(int y, StringBuilder str, string tmp);

        //public static List<(Func<int, int, bool>, Func<int, StringBuilder, string, int>)> Tuples = new List<(Func<int, int, bool>, Func<int, StringBuilder, string, int>)>
        //{
        //    ((y, x) => y > x, Superior),
        //    ((y, x) => y < x, Inferior)
        //};

        static void Superior(int val, StringBuilder str, string tmp)
        {
            str.Append(tmp);
            val--;
        }

        static void Inferior(int val, StringBuilder str, string tmp)
        {
            str.Append(tmp);
            val++;
        }

   
        static void Thor() //thor of coding game
        {
            int lightX = 6; // the X position of the light of power
            int lightY = 2; // the Y position of the light of power
            int initialTX = 0; // Thor's starting X position
            int initialTY = 5; // Thor's starting Y position

            StringBuilder builder = new StringBuilder();

            var ls = new List<Tmpr>
            {
                new Tmpr{F1 = initialTY, F2 = lightY, Fuc = (y, x) => y < x && y < 17, Del = Inferior, Str = "S" },
                new Tmpr{F1 = initialTY, F2 = lightY, Fuc = (y, x) => y > x, Del = Superior, Str = "N" },
                new Tmpr{F1 = initialTX, F2 = lightX, Fuc = (y, x) => y < x, Del = Inferior, Str = "E" },
                new Tmpr{F1 = initialTX, F2 = lightX, Fuc = (y, x) => y > x, Del = Superior, Str = "W" },
               


                //(initialTX, lightX, (y, x) => y < x, Inferior, "E"),
                //(initialTX, lightX, (y, x) => y > x, Superior, "W"),
                //(initialTY, lightY, (y, x) => y < x, Inferior, "S"),
                //(initialTY, lightY, (y, x) => y > x, Superior, "N")
            };

            foreach (var it in ls)
            {
                if (it.Fuc(it.F1, it.F2))
                    it.Del(it.F1, builder, it.Str);
            }
        }

        static void Main(string[] args)
        {
            var tmp = new StringTry("azbnsdflkopaizepoe");

            tmp.CountDistinct();
            Console.ReadKey();
        }
    }
}
