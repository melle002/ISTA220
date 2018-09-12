using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Utility
    {
        public static int sum(params int[] paramList)
        {
            Console.WriteLine("Using paramList");
            if(paramList == null)
            {
                throw new ArgumentException("Util.Sum: Null parameter list");
            }
            if (paramList.Length == 0)
            {
                throw new ArgumentException("Util.Sum: empty parameter list");
            }

            int sumTotal = 0;

            foreach  (int i in paramList)
            {
                sumTotal += i;
                //sumTotal = i + sumTotal; does the same as sumTotal += i
            }
            return sumTotal;
        }
        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using optional parameters");
            int sumTotal = param1 + param2 + param3 + param4;
            return sumTotal; 
        }

    }
}
