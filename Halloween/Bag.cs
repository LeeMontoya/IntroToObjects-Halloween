using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween
{
    class Bag
    {

        public List<Candy> Candies { get; set; }


        /// <summary>
        /// Bag Constructor
        /// </summary>
        public  Bag()
        {
            Candies = new List<Candy>();
        }

        public void AddCandy(Candy candy)
        {
            Candies.Add(candy);
        }

        public void AddCandy(string candyName)
        {
            Candies.Add(new Candy(candyName));
        }

        /// <summary>
        /// This is a method, a function that performs an action on the object
        /// </summary>
        /// <returns>The number of candies in the bag</returns>
        public int CandyCount()
        {
            return this.Candies.Count();
        }
    }
}
