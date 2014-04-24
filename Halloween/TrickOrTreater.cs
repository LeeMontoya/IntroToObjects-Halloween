using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween
{
    class TrickOrTreater
    {
        //These are properties, they describe the object
        public string Costume { get; set; }
        public Bag Bag { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// This is the constructor, it is used when calling the New TrickOrTreater() method
        /// </summary>
        /// <param name="Costume">Costume they are wearing</param>
        public TrickOrTreater(string name, string costume)
        {
            //set the name of the object to the name parameter
            this.Name = name;
            //set the costume of the object to the costume parameter
            this.Costume = costume;
            //initialize (make a new object) the bag.
            this.Bag = new Bag();
            
        }

      
        /// <summary>
        /// Adds candy to the trick or treater's bag
        /// </summary>
        /// <param name="candyName">name of the candy</param>
        public void AddCandy(string candyName)
        {
            this.Bag.AddCandy(candyName);
        }
    }
}
