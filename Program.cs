using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThisKeywordPoc.Model;

namespace ThisKeywordPoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Calculator calculator = new Calculator();
           calculator.CalculatorAdd(3).CalculatorAdd(4).CalculatorAdd(3);
            Console.WriteLine(calculator.Result);


          /*  //Console.WriteLine(calculator._result); cannot call
            Console.WriteLine(calculator.CalculatorCount());*/


            Employee employee = new Employee();
            employee.AttendMeeting();


            Person person = new Person("Akash");
            person.Greet();
            //Accessing Instance Members:
            //Use this to access instance methods, properties, or fields from within the class.


            Collision colision = new Collision(5);
            
            Console.WriteLine(colision.DoSomething(7));

        }
    }
  
}
