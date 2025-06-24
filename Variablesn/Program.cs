using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variablesn
{
  
    internal class Program
    {
        /*
         * Welcome to GIT.
         */
       
        /*
         * Varibles: varible is used to store some value 
         * it depends on type of the data.
         * A varibale name should not start with a number and a special character
         * except underscore(_)
         * syntax:
         * datatype <varibalename> =value;
         * int a=100;
         */
        static void Main(string[] args)
        {

            //interger data types.
            //int a = 100;
            //place holder used to hold the value of a 
            //Console.WriteLine("value of a is {0}",a);
            //int AGE = 20;
            //Console.WriteLine("your age is "+AGE);
            int a, b, c;
            a = 100;
            b = 200;
            c = a + b;
          //  if a varible is with in a method it is a local varibles.
            Console.WriteLine("sum of {0} and {1} is {2}",a,b,c);





        }

    }
}
