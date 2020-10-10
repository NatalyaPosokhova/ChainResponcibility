using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Kata_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformer successConversionTransform = new CheckSuccessConversionTransform(null);
            Transformer spacesTransform = new CheckSpacesTransform(successConversionTransform);
            Transformer emptyStringTransform = new CheckEmptyStringTransform(spacesTransform);
            Transformer nullTransform = new CheckNullTransform(emptyStringTransform);

            Calc calculator = new Calc();
            //calculator.Add();
        }
    }
}
