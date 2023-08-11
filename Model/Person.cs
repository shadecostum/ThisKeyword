using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThisKeywordPoc.Model
{
    //Passing the Current Instance to Other Methods:
    //'this' is used to refer to the instance variable
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
