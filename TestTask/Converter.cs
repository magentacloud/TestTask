using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class Converter
    {
        public string BinaryToDecimal(string binaryNumber)
        {
            int result = 0;
            var splittedBinaryNumber = binaryNumber.ToCharArray();
            var emptyArray = Enumerable.Repeat('0', 32 - splittedBinaryNumber.Length);
            var fullNumber = emptyArray.Concat<char>(splittedBinaryNumber).ToList<char>();
            for (int i = 0; i < fullNumber.Count; i++)
            {
                result += (int)Math.Pow(Int32.Parse(fullNumber[i].ToString()) * 2, fullNumber.Count - i - 1);
            }
            return result.ToString();
        }
        public string DecimalToBinary(string decimalNumber)
        {
            List<char> result = new List<char>();
            int num = Int32.Parse(decimalNumber);
            for (int i = 0; i < 32; i++)
            {
                if ((int)num % 2 == 0)
                {
                    result.Add('0');
                    num = num / 2;
                }
                else
                {
                    result.Add('1');
                    num = (num - 1) / 2;
                }
                
            }
            result.Reverse();
            return String.Join("", result);
        }
    }
}
