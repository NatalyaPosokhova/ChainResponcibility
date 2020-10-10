using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Kata_Calc
{
    public class CheckNullTransform : Transformer
    {
        private Transformer _next;
        public CheckNullTransform(Transformer Next) : base(Next)
        {
          
        }
        public override int[] GetNumListFromString(string numbers)
        {
            if(numbers == null)
            {
                throw new ArgumentNullException();
            }
            return _next.GetNumListFromString(numbers);
        }
    }
}
