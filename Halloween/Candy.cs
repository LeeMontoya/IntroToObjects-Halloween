using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween
{
    class Candy
    {
        public string Name { get; set; }

        /// <summary>
        /// Candy Constructor
        /// </summary>
        /// <param name="candyName">Name of the candy to add</param>
        public Candy(string candyName)
        {
            this.Name = candyName;
        }
    }
}
