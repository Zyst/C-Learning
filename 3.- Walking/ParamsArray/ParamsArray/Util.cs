using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Util
    {
        public static int Sum(params int[] paramList)
        {
            if (paramList == null)
            {
                throw new ArgumentException("Util.Sum: null parameter list");
            }

            if (paramList.Length == 0)
            {
                throw new ArgumentException("Util.Sum: empty parameter list");
            }

            int sumTotal = 0;

            foreach (int i in paramList)
            {
                sumTotal += i;
            }

            return sumTotal;
        }
    }
}
