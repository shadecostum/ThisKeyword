using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ThisKeywordPoc.Model;

namespace ThisKeywordPoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------To refer to the current object:----------------------------");
            Calculator calculator = new Calculator();
           calculator.CalculatorAdd(3).CalculatorAdd(4).CalculatorAdd(3);
            Console.WriteLine(" refer the current object:"+calculator.Result);


            /*  //Console.WriteLine(calculator._result); cannot call
              Console.WriteLine(calculator.CalculatorCount());*/

            Console.WriteLine("-------------method inside another method calling through this keyword-------------------------------");
            Employee employee = new Employee();
            employee.AttendMeeting();

            Console.WriteLine("------------------'this' is used to refer to the instance variable-------------------------");
            Person person = new Person("Akash");
            person.Greet();
            //Accessing Instance Members:
            //Use this to access instance methods, properties, or fields from within the class.

           /* Console.WriteLine("--------------------------------------------");
            Collision colision = new Collision(5);
            Console.WriteLine(colision.DoSomething(7));*/

            Console.WriteLine("------------------invokes the constructor with 2 parameters--------------------------");

            Chaining costumer1 = new Chaining();
            Console.WriteLine(costumer1.ShowCostumer());
            Chaining costumer2 = new Chaining(123, "akash");
            Console.WriteLine(costumer2.ShowCostumer());
            Chaining costumer3 = new Chaining(223, "king", "king@gmail.com");
            Console.WriteLine(costumer3.ShowCostumer());
           
           
        }
    }
  
}
