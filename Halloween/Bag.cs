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
            this.Candies = new List<Candy>();
        }

        //thid is a method
        public void AddCandy(Candy candy)
        {
            this.Candies.Add(candy);
        }

        public void AddCandy(string candyName)
        {
            this.Candies.Add(new Candy(candyName));
        }

        /// <summary>
        /// This is a function, a function that performs an action on the object
        /// </summary>
        /// <returns>The number of candies in the bag</returns>
        public int CandyCount()
        {
            return this.Candies.Count();
        }

        public int NumberOfCandyVariety()
        {
            return this.Candies.Select(x => x.Name).Distinct().Count();
        }
    }
}
