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

            var me = new TrickOrTreater("Jordan", "Bane");
            me.AddCandy("Reeses");
            me.AddCandy("Twix");
            me.AddCandy("Snickers");
            me.AddCandy("Starburst");

            Console.WriteLine(me.Costume + " is the costume I'm wearing.");
            Console.WriteLine("I have " + me.Bag.CandyCount() + " pieces of candy.");

            me.AddCandy("Twix");
            me.AddCandy("Snickers");
            me.AddCandy("Reeses");

            Console.WriteLine("I have " + me.Bag.NumberOfCandyVariety() + " types of candy.");



            Console.ReadKey();
        }
    }
}
