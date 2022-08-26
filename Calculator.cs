using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Rehearse
{
    public class Calculator
    {
        public static int Add(params int[] numbers)
        {
            var sum =0;
            /*foreach (int i in numbers)
                sum += i;
            return sum;*/

            // using linq
            numbers.ToList().ForEach(i => sum+=i);
            return sum; 
        } 

    }
}
