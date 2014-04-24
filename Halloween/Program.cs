using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a new trick or treater
            var batman = new TrickOrTreater("Ben", "Batman");
            batman.AddCandy("Skittles");
            batman.AddCandy("Snickers");

            Console.WriteLine(batman.Costume + "'s bag has " + batman.Bag.CandyCount() + " pieces of candy in it");



            Console.ReadKey();
        }
    }
}
