using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TDD_Kata_Calc
{
    class Calc
    {
        public int Add(List<int> intNumbersList)
        {
            int sum = 0;
            intNumbersList.ForEach(num => sum += num );
            return sum;
        }
    }
}
