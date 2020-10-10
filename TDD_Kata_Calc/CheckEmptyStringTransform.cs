using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Kata_Calc
{
    public class CheckEmptyStringTransform : Transformer
    {
        public CheckEmptyStringTransform(Transformer Next) : base(Next)
        {

        }

        public override int[] GetNumListFromString(string numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentNullException();
            }
            return base.GetNumListFromString(numbers);
        }
    }
}
