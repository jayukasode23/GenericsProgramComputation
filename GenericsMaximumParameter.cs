using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class GenericsMaximumParameter
    {
        public T GenericsMaximumParameterIs<T>(T number1, T number2, T number3, T number4) where T : IComparable
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
