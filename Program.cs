using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
 

            PanDa panDa = new PanDa("pan dah");
            PanDa panDa2 = new PanDa("pan dah2");

            Console.WriteLine(panDa.name);
            Console.WriteLine(panDa2.name);

            Console.WriteLine(PanDa.allCount);
            Console.WriteLine(100_000_000);

            Console.Read();

        }
    }
    public class PanDa {

        public string name { get; set; }

        public static int allCount { get; set; }


        public PanDa(string _name) {

            name = _name;
            allCount++;


        }


    }


}
