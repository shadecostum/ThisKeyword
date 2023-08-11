using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeywordPoc.Model
{
    internal class Calculator
    {
        private int _result;


        public int Result
        {
            get { return _result; }//Know _result varible accesbile in any fuction
            set { _result = value; }//this used to value setting from main function can set directly
        }


        public  Calculator CalculatorAdd(int number1)
        {
            Result += number1;
           
            return this;
        }
      
       /* public int CalculatorCount() { 
            _result = 0;
            return _result; }*/
    }
}
