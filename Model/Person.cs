using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeywordPoc.Model
{
    internal class Person
    {
       
            private string namee;

            public Person(string name)
            {
                this.namee = name;
            }

            public void Greet()
            {
                Console.WriteLine($"Hello, my name is {this.namee}.");
            }
        

    }
}
