using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Kata_Calc
{
    public class CheckSpacesTransform : Transformer
    {
        public CheckSpacesTransform(Transformer Next) : base(Next)
        {

        }
        public override int[] GetNumListFromString(string numbers)
        {
            if (numbers.Contains(' '))
            {
                throw new ArgumentNullException();
            }
            return base.GetNumListFromString(numbers);
        }
    }
}
