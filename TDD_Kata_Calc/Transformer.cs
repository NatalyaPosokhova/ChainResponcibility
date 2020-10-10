using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Kata_Calc
{
    public abstract class Transformer
    {
        private Transformer _next;

        public Transformer(Transformer Next)
        {
            _next = Next;
        }

        public virtual int[] GetNumListFromString(string numbers)
        {
            return _next.GetNumListFromString(numbers);
        }
    }
}
