using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TDD_Kata_Calc
{
    public class Calculator
    {
        /// <summary>
        /// Calculates the sum of two numbers.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Sum of two numbers in int.</returns>
        public int Add(string numbers)
        {
            int error = -1;

            string beginningPattern = "^//\\D\\n";
            string[] stringNumbersArr = new string[] { };
            string dividedPattern = String.Empty;

            List<int> intNumbersList = new List<int>();

            if (IsNumStringEmpty(numbers))
            {
                return 0;
            }

            if(IsNumStringContainsSpace(numbers))
            {
                return error;
            }

            if (Regex.IsMatch(numbers,beginningPattern))
            {
                dividedPattern = "\\" + numbers[2].ToString();
                numbers =  Regex.Split(numbers, beginningPattern)[1];
                stringNumbersArr = Regex.Split(numbers, dividedPattern);
            }
            else
            {
                dividedPattern = @",\n|\n,|[,\n]";
                stringNumbersArr = Regex.Split(numbers, dividedPattern);
            }

            if (!IsSuccessConvertStringArrToIntList(stringNumbersArr, ref intNumbersList))
            {
                return error;
            }
            return intNumbersList.Sum();
        }

        /// <summary>
        /// Check if entered numbers string is empty.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>True if Empty, False is not empty.</returns>
        private bool IsNumStringEmpty(string numbers)
        {
            if (numbers.Length == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check if entered string contains space symbol. 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>True if string contains space, False - if string doesn't contain space.</returns>
        private bool IsNumStringContainsSpace(string numbers)
        {
            if (numbers.Contains(' '))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check if every element in string array could be converted to int. Fill the List of int by converted values.
        /// </summary>
        /// <param name="stringNumbersArr"></param>
        /// <param name="intNumbersList"></param>
        /// <returns>True if every element of string element could be converted to int, False - if not.</returns>
        private bool IsSuccessConvertStringArrToIntList(string[] stringNumbersArr, ref List<int> intNumbersList)
        {
            foreach (var strNum in stringNumbersArr)
            {
                int value;
                if (!Int32.TryParse(strNum, out value))
                {
                    return false;
                }
                else
                {
                    intNumbersList.Add(value);
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if entered List<int> contains more than two numbers
        /// </summary>
        /// <param name="intNumbersList"></param>
        /// <returns>True if List contains more than two numbers, else - false.</returns>
        #region
        //private bool IsListContainsMoreThanTwoNums(List<int> intNumbersList)
        //{
        //    if (intNumbersList.Count > 2)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        #endregion
    }
}
