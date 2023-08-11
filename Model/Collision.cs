using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeywordPoc.Model
{
    internal class Collision
    {
        private int x;

        public Collision(int x)
        {
            this.x = x; // Referring to the instance variable "x"
            Console.WriteLine(x);
        }

        public int DoSomething(int x)
        {
            this.x = x; // Setting the instance variable "x" using "this"
            return this.x;
        }
    }
}
