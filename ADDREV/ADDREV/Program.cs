using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDREV
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                string temp = Console.ReadLine();

                int spaceIndex = temp.IndexOf(' ');
                string firstNumber = temp.Substring(0, spaceIndex);
                string secondNumber = temp.Substring(spaceIndex + 1);
                firstNumber = Reverse(firstNumber);
                secondNumber = Reverse(secondNumber);

                int firstReversedNumber = Convert.ToInt32(firstNumber);
                int secondReversedNumber = Convert.ToInt32(secondNumber);
                int ReversedTotality = firstReversedNumber + secondReversedNumber;
                temp = Reverse(Convert.ToString(ReversedTotality));
                ReversedTotality = Convert.ToInt32(temp);
                Console.WriteLine(ReversedTotality);
            }
        }

        static string Reverse(string input)
        {
            char[] reversed = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversed[input.Length - i - 1] = input[i];
            }
            return new string(reversed);
        }
    }
}
