using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Kata_Calc
{
    public class CheckSuccessConversionTransform : Transformer
    {
        public CheckSuccessConversionTransform(Transformer Next) : base(Next)
        {

        }
        public override int[] GetNumListFromString(string numbers)
        {
            //foreach (var strNum in stringNumbersArr)
            //{
            //    int value;
            //    if (!Int32.TryParse(strNum, out value))
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        intNumbersList.Add(value);
            //    }
            //}
            //return true;
            //if (numbers == null)
            //{
            //    throw new ArgumentNullException();
            //}
            return base.GetNumListFromString(numbers);
        }
    }
}
