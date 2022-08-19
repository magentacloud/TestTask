using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class IOHandler
    {
        int notationId;
        string inputNumber;
        Converter converter = new Converter();
        public void GetNotation()
        {
            Console.WriteLine("Введите номер исходной системы счисления. 1 — двоичная, 2 — десятичная");

            notationId = Int32.Parse(Console.ReadLine());
            if (notationId == 1)
            {
                Console.WriteLine("Введите двоичное число");
            }
            else if (notationId == 2)
            {
                Console.WriteLine("Введите десятичное число");
            }
            else
            {
                Console.WriteLine("Неверный номер системы. Попробуйте ещё раз");
                GetNotation();
            }
        }

        public void ProcessBinaryNumber()
        {
            inputNumber = Console.ReadLine();
            var splittedNumber = inputNumber.ToCharArray();
            if(splittedNumber.Length > 32)
            {
                Console.WriteLine("Допустимая длина числа превышена");
                return;
            }

            if (Array.Exists(splittedNumber, element => element != '1' & element != '0') )
            {
                Console.WriteLine("Недопустимые символы в двоичном числе");
                return;
            }
            var output = converter.BinaryToDecimal(inputNumber);
            Console.WriteLine(output);
        }
        public void ProcessDecimalNumber()
        {
            inputNumber = Console.ReadLine();
            var splittedNumber = inputNumber.ToCharArray();
            if (Int64.Parse(inputNumber) > 4294967295)
            {
                Console.WriteLine("Число больше допустимого");
                return;
            }

            if (Array.Exists(splittedNumber, element => !Char.IsDigit(element)))
            {
                Console.WriteLine("Недопустимые символы в двоичном числе");
                return;
            }
            var output = converter.DecimalToBinary(inputNumber);
            Console.WriteLine(output);
        }

        public void GetNumber()
        {
            if (notationId == 1)
                ProcessBinaryNumber();
            else if (notationId == 2)
            {
                ProcessDecimalNumber();
            }
        }
    }
}
