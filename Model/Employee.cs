using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeywordPoc.Model
{
    internal class Employee
    {

        public void Work()
        {
            // Do work

            Console.WriteLine("working in first function");
        }

        public void AttendMeeting()
        {
            Console.WriteLine("working of second function");
            this.Work(); // Error: no method named "Work()" in the current scope
        }

    
    }
}
