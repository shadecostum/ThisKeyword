using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeywordPoc.Model
{
    internal class Chaining
    {
        private int _id;
        private string _name;
        private readonly string _email;
        int agt = 30;

       

        public Chaining()
        {
            Console.WriteLine("-------------Constructor--------------------");
        }
        public Chaining(int id, string name)
        {
            _id = id;
            _name = name;
            calculate(id);
            calculate(id);

        }

        private void calculate(int id)
        {
            _id = agt + id;


        }

        public Chaining(int id, string name, string email) : this(id, name)
        {
            _email = email;
        }
        //Calling Other Constructors:

        public string ShowCostumer()
        {
            return $"id:{_id},name:{_name}" + $"Email:{_email}";
        }
    }
}
