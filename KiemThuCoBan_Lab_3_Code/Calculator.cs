using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuCoBan_Lab_3_Code
{
    public class Calculator
    {
        /// <summary>
        /// Sum of two numbers
        /// </summary>
        /// <param name="theiFirstNumber">First number</param>
        /// <param name="theiSecondNumber">Second number</param>
        /// <returns></returns>
        public int Add(int theiFirstNumber, int theiSecondNumber)
        {
            return theiFirstNumber + theiSecondNumber;
        }
        /// <summary>
        /// Subtract of two numbers
        /// </summary>
        /// <param name="theiFirstNumber">First number</param>
        /// <param name="theiSecondNumber">Second number</param>
        /// <returns></returns>
        public int Subtract(int theiFirstNumber, int theiSecondNumber)
        {
            return theiFirstNumber - theiSecondNumber;
        }
        /// <summary>
        /// Divide of two numbers
        /// </summary>
        /// <param name="theiFirstNumber"></param>
        /// <param name="theiSecondNumber"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        public int Divide(int theiFirstNumber, int theiSecondNumber)
        {
            if (theiSecondNumber == 0)
            {
                throw new DivideByZeroException();
            }
            return theiFirstNumber / theiSecondNumber;
        }
        public double SquareRoot(int theiNumber)
        {
            if(theiNumber < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Math.Sqrt(theiNumber);
        }
    }
}
