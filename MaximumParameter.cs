using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class MaximumParameter
    {
        public int MaximumInteger(int number1, int number2, int number3, int number4)
        {
            if (number1.CompareTo(number2) > 0 && number1.CompareTo(number3) > 0 && number1.CompareTo(number4) > 0)
            {
                return number1;
            }
            if (number2.CompareTo(number1) > 0 && number2.CompareTo(number3) > 0 && number2.CompareTo(number3) > 0)
            {
                return number2;
            }
            if (number3.CompareTo(number1) > 0 && number3.CompareTo(number2) > 0 && number3.CompareTo(number4) > 0)
            {
                return number3;
            }
            if (number4.CompareTo(number1) > 0 && number4.CompareTo(number2) > 0 && number4.CompareTo(number3) > 0)
            {
                return number4;
            }
            return number1;
        }
    }
}
    